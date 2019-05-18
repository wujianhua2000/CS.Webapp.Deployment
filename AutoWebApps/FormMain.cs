using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;

using Hans.Util;

namespace Hans.Web
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private Setting AppINI = new Setting( );

        private string CONST_HANS_GITHUB = "HANS-GITHUB";

        private string CONST_APACHE_ROOT = "APACHE-ROOT";

        private string CONST_LAST_PHP_FILE = "LAST-PHP-FILE";

        private string CONST_LAST_JSP_FILE = "LAST-JSP-FILE";

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        public FormMain( )
        {
            InitializeComponent( );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExit_Click( object sender, EventArgs e )
        {
            this.Close( );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExecJSP_Click( object sender, EventArgs e )
        {
            string htmlfile = this.TextHtmlJSP.Text;

            WebAppExecution.RunTomcat( htmlfile  );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonHtmlJSP_Click( object sender, EventArgs e )
        {
            if ( this.DialogFile.ShowDialog( ) != DialogResult.OK ) return;

            this.TextHtmlJSP.Text = this.DialogFile.FileName;

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonHtmlPHP_Click( object sender, EventArgs e )
        {
            string currfile = this.TextHtmlPHP.Text;

            bool hasfile = ( !string.IsNullOrEmpty( currfile ) );
            if ( hasfile ) this.DialogFile.FileName = currfile;

            if ( this.DialogFile.ShowDialog( ) != DialogResult.OK ) return;

            this.TextHtmlPHP.Text = this.DialogFile.FileName;

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load( object sender, EventArgs e )
        {
            FileInfo fileinfo = new FileInfo( Application.ExecutablePath );
            string filename = fileinfo.DirectoryName + "\\" + Setting.SettingFile;

            bool hasFILE = File.Exists( filename );
            if ( hasFILE ) this.AppINI.Load( );

            this.TextGithub.Text = this.AppINI.Select( this.CONST_HANS_GITHUB );
            this.TextApache.Text = this.AppINI.Select( this.CONST_APACHE_ROOT );

            this.TextHtmlPHP.Text = this.AppINI.Select( this.CONST_LAST_PHP_FILE );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGithub_Click( object sender, EventArgs e )
        {
            string currpath = this.TextGithub.Text;

            bool haspath = ( !string.IsNullOrEmpty( currpath ) );
            if ( haspath ) this.DialogPath.SelectedPath = currpath;

            if ( this.DialogPath.ShowDialog( ) != DialogResult.OK ) return;

            this.TextGithub.Text = this.DialogPath.SelectedPath;

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonApache_Click( object sender, EventArgs e )
        {
            string currpath = this.TextApache.Text;

            bool haspath = ( !string.IsNullOrEmpty( currpath ) );
            if ( haspath ) this.DialogPath.SelectedPath = currpath;

            if ( this.DialogPath.ShowDialog( ) != DialogResult.OK ) return;

            this.TextApache.Text = this.DialogPath.SelectedPath;

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCopying_Click( object sender, EventArgs e )
        {
            string srcpath = this.TextGithub.Text;
            string dstpath = this.TextApache.Text;

            if ( string.IsNullOrEmpty( srcpath ) ) return;
            if ( string.IsNullOrEmpty( dstpath ) ) return;

            this.AppINI.Plus( this.CONST_HANS_GITHUB, srcpath );
            this.AppINI.Plus( this.CONST_APACHE_ROOT, dstpath );
            this.AppINI.Save( );

            PathFile pathfile = new PathFile( );

            pathfile.SeekingPath( srcpath );

            List<DirectoryInfo> listpath = pathfile.Paths;

            var listname = from lst in listpath
                           orderby lst.FullName
                           select lst.FullName;

            foreach ( var code in listname )
            {
                string newPath = dstpath + code.Substring( srcpath.Length );

                if ( Directory.Exists( newPath ) ) continue;

                if ( newPath.ToLower( ).Contains( ".git" ) ) continue;
                
                Directory.CreateDirectory( newPath );
            }

            List<FileInfo> listing = pathfile.SeekingFiles( );

            foreach ( FileInfo fileinfo in listing )
            {
                if ( fileinfo.FullName.ToLower( ).Contains( "\\.git\\" ) ) continue;

                string newName = fileinfo.FullName
                                         .Substring( srcpath.Length );

                fileinfo.CopyTo( dstpath + newName, true );
            }

            Process.Start( "explorer.exe", dstpath );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExecPHP_Click( object sender, EventArgs e )
        {
            string htmlfile = this.TextHtmlPHP.Text;

            this.AppINI.Plus( this.CONST_LAST_PHP_FILE, htmlfile );
            this.AppINI.Save( );

            WebAppExecution.RunApache( htmlfile );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFirefoxPHP_Click( object sender, EventArgs e )
        {
            string firefox = @"C:\Program Files\Mozilla Firefox\firefox.exe";

            string htmlfile = this.TextHtmlPHP.Text;

            this.AppINI.Plus( this.CONST_LAST_PHP_FILE, htmlfile );
            this.AppINI.Save( );

            WebAppExecution.RunApache( htmlfile, firefox );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 一个递归
        /// </summary>
        /// <param name="root"></param>
        //private void SeekTomcatPath( DirectoryInfo root )
        //{
        //    string pathname = root.FullName;

        //    if ( pathname.EndsWith( "webapps" ) )
        //    {
        //        this.TomcatPath = root;
        //        return;
        //    }

        //    DirectoryInfo[] pathlist = root.GetDirectories( );

        //    foreach ( DirectoryInfo path in pathlist )
        //        SeekTomcatPath( path );

        //    return;
        //}

        //private void ButtonTomc_Click( object sender, EventArgs e )
        //{
        //    if ( this.DialogPath.ShowDialog( ) != DialogResult.OK ) return;

        //    、、this.TextTomc.Text = this.DialogPath.SelectedPath;

        //    return;
        //}

    }
}
