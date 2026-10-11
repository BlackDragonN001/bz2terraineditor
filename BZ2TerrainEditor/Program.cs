using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace BZ2TerrainEditor
{
	/// <summary>
	/// Main class.
	/// </summary>
	public static class Program
	{
		private static int editorInstances;

		/// <summary>
		/// Gets or sets the number of editor instances.
		/// The application will exit when the number of instaces equals 0.
		/// </summary>
		public static int EditorInstances
		{
			get { return editorInstances; }
			set
			{
				editorInstances = value;
				if (editorInstances == 0)
				{
					Application.Exit();
				}
			}
		}
	
		/// <summary>
		/// Entry point.
		/// </summary>
		[STAThread]
		public static void Main(string[] args)
		{
            AppDomain.CurrentDomain.AssemblyResolve += (sender, resolveArgs) =>
            {
                string assemblySimpleName = new AssemblyName(resolveArgs.Name).Name;
                string resourceName = assemblySimpleName + ".dll";

                Assembly assembly = Assembly.GetExecutingAssembly();
                using (Stream stream = assembly.GetManifestResourceStream(resourceName)
                    ?? assembly.GetManifestResourceStream(typeof(Program).Namespace + "." + resourceName))
                {
                    if (stream == null)
                    {
                        string[] names = assembly.GetManifestResourceNames();
                        foreach (string name in names)
                        {
                            if (name.EndsWith(resourceName, StringComparison.OrdinalIgnoreCase))
                            {
                                using (Stream fallbackStream = assembly.GetManifestResourceStream(name))
                                {
                                    if (fallbackStream != null)
                                    {
                                        byte[] data = new byte[fallbackStream.Length];
                                        fallbackStream.Read(data, 0, data.Length);
                                        return Assembly.Load(data);
                                    }
                                }
                            }
                        }
                        return null;
                    }

                    byte[] assemblyData = new byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            };

            Application.EnableVisualStyles();

			Editor editor;

			if (args.Length > 0)
				editor = new Editor(args[0]);
			else
				editor = new Editor();

			editor.Show();
			Application.Run();
		}
	}
}
