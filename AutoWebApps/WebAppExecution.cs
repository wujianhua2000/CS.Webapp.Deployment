using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Hans.Web
{
    class WebAppExecution
    {
        //.....................................................................
        private static string HTTP_TOMCAT = "http://localhost:8080/";

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlfile"></param>
        public static void RunTomcat( string htmlfile )
        {
            FileInfo tomcat = new FileInfo( htmlfile );

            int idx = tomcat.DirectoryName.IndexOf( "webapps" );

            if ( idx < 0 )
            {
                MessageBox.Show( "请选择一个在 TOMCAT 内的文件（JSP,HTML）." );
                return;
            }

            string pathname = tomcat.DirectoryName
                                    .Substring( idx + "webapps".Length );

            if ( pathname.StartsWith( "//" ) ) pathname = pathname.Substring( 1 );

            string htmlink = "http://localhost:8080/" + pathname + "/" + tomcat.Name;

            if ( string.IsNullOrWhiteSpace( pathname ) )
                htmlink = "http://localhost:8080/" + tomcat.Name;

            Process.Start( "IExplore.exe", htmlink );

            //下面使用  fire-fox 火狐
            //Process.Start( "firefox.exe", htmlink );

            return;
        }
        
        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlfile"></param>
        public static void RunApache( string htmlfile )
        {
            FileInfo tomcat = new FileInfo( htmlfile );

            int idx = tomcat.DirectoryName.IndexOf( "htdocs" );

            if ( idx < 0 )
            {
                MessageBox.Show( "请选择一个在 APACHE 内的文件（PHP,HTML）." );
                return;
            }

            idx = idx + "htdocs".Length;
            string pathname = tomcat.DirectoryName.Substring( idx );

            string htmlink = "http://localhost/" + pathname + "/" + tomcat.Name;

            if (string.IsNullOrWhiteSpace( pathname))
                htmlink = "http://localhost/" + tomcat.Name;

            Process.Start( "IExplore.exe", htmlink );

            //下面使用  fire-fox 火狐
            //Process.Start( "firefox.exe", htmlink );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlfile"></param>
        /// <param name="explorer"></param>
        public static void RunApache( string htmlfile, string explorer )
        {
            FileInfo tomcat = new FileInfo( htmlfile );

            int idx = tomcat.DirectoryName.IndexOf( "htdocs" );

            if ( idx < 0 )
            {
                MessageBox.Show( "请选择一个在 APACHE 内的文件（PHP,HTML）." );
                return;
            }

            idx = idx + "htdocs".Length;
            string pathname = tomcat.DirectoryName.Substring( idx );

            string htmlink = "http://localhost/" + pathname + "/" + tomcat.Name;

            if ( string.IsNullOrWhiteSpace( pathname ) )
                htmlink = "http://localhost/" + tomcat.Name;

            //Process.Start( "IExplore.exe", htmlink );
            Process.Start( explorer, htmlink );

            return;
        }

        //.....................................................................
    }
}
