using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Hans.Web
{
    class Setting
    {
        /// <summary>
        /// 
        /// </summary>
        private Dictionary<string, string> CFGs = new Dictionary<string, string>( );

        /// <summary>
        /// 
        /// </summary>
        public static string SettingFile = "setting.txt";

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void Plus( string name, string value )
        {
            bool hasKEY = this.CFGs.ContainsKey( name );
            if ( hasKEY ) this.CFGs.Remove( name );

            this.CFGs.Add( name, value );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string Select( string name )
        {
            bool hasKEY = this.CFGs.ContainsKey( name );
            if ( hasKEY ) return this.CFGs[ name ];

            return string.Empty;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        public void Load( )
        {
            FileInfo fileinfo = new FileInfo( Application.ExecutablePath );

            string filename = fileinfo.DirectoryName + "\\" + SettingFile;

            string[ ] datalines = File.ReadAllLines( filename, Encoding.Default );

            this.CFGs.Clear( );

            int count = datalines.Length;
            for ( int idx = 0; idx < count; )
            {
                if ( idx >= count ) break;
                string kname = datalines[ idx++ ];

                if ( idx >= count ) break;
                string value = datalines[ idx++ ];

                this.CFGs.Add( kname, value );
            }

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        public void Save( )
        {
            FileInfo fileinfo = new FileInfo( Application.ExecutablePath );

            string filename = fileinfo.DirectoryName + "\\" + SettingFile;

            List<string> listing = new List<string>( );

            foreach ( string key in this.CFGs.Keys )
            {
                string value = this.CFGs[ key ];

                listing.Add( key );
                listing.Add( value );
            }

            File.WriteAllLines( filename, listing, Encoding.Default );

            return;
        }

        //.....................................................................
    }
}
