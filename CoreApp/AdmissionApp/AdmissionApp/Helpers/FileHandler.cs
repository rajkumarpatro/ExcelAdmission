﻿
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
namespace Admission.Helpers
{
    public class FileHandler
    {
        public static string SaveUploadedFile( string filePrefix)
        {
            return "";
            //string fname = String.Empty;

            //if (Request.Files.Count > 0)
            //{
            //    try
            //    {
            //        HttpFileCollectionBase files = Request.Files;

            //        HttpPostedFileBase file = files[0];

            //        if (Request.Browser.Browser.ToUpper() == "IE" || Request.Browser.Browser.ToUpper() == "INTERNETEXPLORER")
            //        {
            //            string[] testfiles = file.FileName.Split(new char[] { '\\' });
            //            fname = testfiles[testfiles.Length - 1];
            //        }
            //        else
            //        {
            //            fname = file.FileName;
            //        }

            //        var uploadPath = ConfigurationManager.AppSettings["UploadPath"].ToString();

            //        // Get the complete folder path and store the file inside it.
            //        var guidId = Guid.NewGuid();
            //        var targetpath = $"{uploadPath}/{filePrefix}_{guidId}_{fname}";
            //        var fPath = Path.Combine(HttpContext.Current.Server.MapPath(uploadPath), $"{filePrefix}_{guidId}_{fname}");

            //        file.SaveAs(fPath);

            //        //Returns message that successfully uploaded

            //        return (targetpath);
            //    }
            //    catch (Exception ex)
            //    {
            //        return ("Error occurred. Error details: " + ex.Message);
            //    }
            //}

            //return fname;
        }

        public static List<dynamic> UploadedMultipleFiles(string filePrefix, int id)
        {
            var paths = new List<dynamic>();

            //List<string> paths = new List<string>();
            //string fname = String.Empty;

            //if (Request.Files.Count > 0)
            //{
            //    try
            //    {
            //        HttpFileCollectionBase files = Request.Files;
            //        //HttpPostedFileBase file = files[0];

            //        for (int i = 0; i < files.Count; i++)
            //        {
            //            HttpPostedFileBase file = files[i];

            //            if (Request.Browser.Browser.ToUpper() == "IE" || Request.Browser.Browser.ToUpper() == "INTERNETEXPLORER")
            //            {
            //                string[] testfiles = file.FileName.Split(new char[] { '\\' });
            //                fname = testfiles[testfiles.Length - 1];
            //            }
            //            else
            //            {
            //                fname = file.FileName;
            //            }

            //            var uploadPath = ConfigurationManager.AppSettings["UploadPath"].ToString();

            //            // Get the complete folder path and store the file inside it.
            //            var guidId = Guid.NewGuid();
            //            var targetpath = $"{uploadPath}/{filePrefix}_{guidId}_{fname}";
            //            var fPath = Path.Combine(HttpContext.Current.Server.MapPath(uploadPath), $"{filePrefix}_{guidId}_{fname}");

            //            file.SaveAs(fPath);

            //            paths.Add(new { name = Path.ChangeExtension(fname, null), path = targetpath });
            //        }


            //        //Returns message that successfully uploaded

            //        return paths;
            //    }
            //    catch (Exception ex)
            //    {
            //        //return ("Error occurred. Error details: " + ex.Message);
            //    }
            //}

            return paths;
        }
        public static string SaveFile(string FileFrom)
        {
            string fname;

            //if (Request.Files.Count > 0)
            //{
            //    try
            //    {
            //        //  Get all files from Request object
            //        HttpFileCollectionBase files = Request.Files;

            //        HttpPostedFileBase file = files[0];

            //        // Checking for Internet Explorer
            //        if (Request.Browser.Browser.ToUpper() == "IE" || Request.Browser.Browser.ToUpper() == "INTERNETEXPLORER")
            //        {
            //            string[] testfiles = file.FileName.Split(new char[] { '\\' });
            //            fname = testfiles[testfiles.Length - 1];
            //        }
            //        else
            //        {
            //            fname = file.FileName;
            //        }

            //        var uploadPath = ConfigurationManager.AppSettings["UploadPath"].ToString();

            //        // Get the complete folder path and store the file inside it.
            //        var guidId = Guid.NewGuid();
            //        fname = Path.Combine(HttpContext.Current.Server.MapPath(uploadPath), FileFrom + Path.GetExtension(file.FileName));

            //        file.SaveAs(fname);

            //        //Returns message that successfully uploaded

            //        return (fname);
            //    }
            //    catch (Exception ex)
            //    {
            //        return ("Error occurred. Error details: " + ex.Message);
            //    }
            //}

            return "";
        }
    }
}