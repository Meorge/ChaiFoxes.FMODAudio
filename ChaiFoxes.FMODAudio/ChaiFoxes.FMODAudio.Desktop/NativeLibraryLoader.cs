using System;
using System.IO;
using System.Runtime.InteropServices;

namespace ChaiFoxes.FMODAudio
{
	/// Windows and Linux-specific part of an audio manager.
	public static class NativeLibraryLoader
	{
//		[DllImport("kernel32.dll")]
//		private static extern IntPtr LoadLibrary(string dllToLoad);

//	// NOTE: To make native libraries work on Linux, we also need <dllmap> entries in App.config.
//#if MONOMAC
//		[DllImport("libdl")]
//#else
//		[DllImport("libdl.so.2")]
//#endif
//		private static extern IntPtr dlopen(string filename, int flags);

		private const int RTLD_LAZY = 0x0001;

		/// <summary>
		/// Loads Windows or Linux native library.
		/// </summary>
		public static void LoadNativeLibrary(string libName)
		{
			NativeLibrary.Load("lib" + libName + ".dylib");
			//if (Environment.OSVersion.Platform != PlatformID.Unix)
			//{
			//	if (Environment.Is64BitProcess)
			//	{
			//		LoadLibrary(Path.GetFullPath("x64/" + libName));
			//	}
			//	else
			//	{
			//		LoadLibrary(Path.GetFullPath("x86/" + libName));
			//	}
			//}
			//else
			//{

			//	Console.WriteLine($"FMOD DEBUG - Environment is {Environment.OSVersion.Platform}, libName = {libName}");
			//	if (Environment.Is64BitProcess)
			//	{
			//		Console.WriteLine("FMOD DEBUG - 64 bit");
			//		Console.WriteLine("Attempting to load library at " + Path.GetFullPath("lib" + libName + ".dylib"));
			//		dlopen(Path.GetFullPath("lib" + libName + ".dylib"), RTLD_LAZY);
			//	}
			//	else
			//	{
			//		Console.WriteLine("FMOD DEBUG - not 64 bit???");
			//		dlopen(Path.GetFullPath("/x86/lib" + libName), RTLD_LAZY);
			//	}
			//}
		}
	}
}