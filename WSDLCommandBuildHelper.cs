using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSDLEXEGUI
{

    class WSDLCommandBuildHelper
    {
        private string wsdlExeBinPath;
        private string wsdlClassFileWithPath;
        private string authParam;
        private string wsdlClassNamespace;
        private string wsdlURI;

        public const string OUTPUT_OPTION = "/out";
        public const string USER_OPTION = "/u";
        public const string PASSWORD_OPTION = "/p";
        public const string NAMESPACE_OPTION = "/n";



        public WSDLCommandBuildHelper()
        {
            wsdlExeBinPath = "";
            authParam = "";
            wsdlClassFileWithPath = "";
            wsdlClassNamespace = "";
            wsdlURI = "";
        }
     
        public void generateWsdlExeBinPath(string wsdlExeBin)
        {
            wsdlExeBinPath = wsdlExeBin;
        }
        public void generateWsdlClassFileWithPath(string path, string className)
        {
            wsdlClassFileWithPath =  $"{OUTPUT_OPTION}:{path}\\{className}.cs";
        }

        public void generateAuth(string user, string password)
        {
            authParam = $"{USER_OPTION}:{user} {PASSWORD_OPTION}:{password}";
        }

        public void generateNameSpace(string classNamespace)
        {
            wsdlClassNamespace = $"{NAMESPACE_OPTION}:{classNamespace}";
        }

        public void generateWsdlURI(string wasdlEndpoint)
        {
            wsdlURI = wasdlEndpoint;
        }


        public string getCommandArguments()
        {
            return $"{wsdlClassFileWithPath} {authParam} {wsdlClassNamespace} {wsdlURI}";
        }

        public string getCommandPath()
        {
            return wsdlExeBinPath;
        }

    }
}
