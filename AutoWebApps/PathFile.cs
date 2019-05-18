using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hans.Util
{
    public class PathFile
    {
        /// <summary>
        /// 
        /// </summary>
        private List<DirectoryInfo> ListPath = new List<DirectoryInfo>( );

        /// <summary>
        /// 
        /// </summary>
        public List<DirectoryInfo> Paths
        {
            get { return this.ListPath; }
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pathname"></param>
        public void SeekingPath( string pathname )
        {
            DirectoryInfo rootpath = new DirectoryInfo( pathname );

            this.ListPath.Add( rootpath );

            this.MoreDirectories( rootpath );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rootpath"></param>
        private void MoreDirectories( DirectoryInfo rootpath )
        {
            DirectoryInfo[ ] pathlisting = rootpath.GetDirectories( );

            if ( pathlisting.Length == 0 ) return;

            this.ListPath.AddRange( pathlisting );

            foreach ( DirectoryInfo path in pathlisting ) this.MoreDirectories( path );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<FileInfo> SeekingFiles( )
        {
            List<FileInfo> listing = new List<FileInfo>( );

            foreach ( DirectoryInfo dirc in ListPath ) listing.AddRange( dirc.GetFiles( ) );

            return listing;
        }

        //.....................................................................
    }
}
