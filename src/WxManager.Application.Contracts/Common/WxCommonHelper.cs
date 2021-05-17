using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace WxManager.Application.Contracts.Common
{
    public static class WxCommonHelper
    {



        /// <summary>        
        /// 时间戳转为C#格式时间        
        /// </summary>        
        /// <param name="timeStamp"></param>        
        /// <returns></returns>        
        public static DateTime? ConvertToDateTime(long timeStamp)
        {
            return ConvertToDateTimeUtc(timeStamp)?.ToLocalTime();
        }

        /// <summary>        
        /// 时间戳转为C#格式时间        
        /// </summary>        
        /// <param name="timeStamp"></param>        
        /// <returns></returns>        
        public static DateTime? ConvertToDateTimeUtc(long timeStamp)
        {
            if (timeStamp == 0)
                return default(DateTime?);
            var start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            if (timeStamp.ToString().Length == 13)
            {
                return start.AddMilliseconds(timeStamp);
            }

            return start.AddSeconds(timeStamp);
        }

        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <returns></returns>
        public static string GetTimeStamp(DateTime time, bool milliseconds = false)
        {
            DateTime jan1St1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            if (milliseconds)
            {
                return ((long)(time.ToUniversalTime() - jan1St1970).TotalSeconds).ToString(
                    CultureInfo.InvariantCulture);
            }

            return ((long)(time.ToUniversalTime() - jan1St1970).TotalMilliseconds).ToString(CultureInfo
                .InvariantCulture);
        }

        ///// <summary>
        ///// 本地路径转换成URL相对路径  
        ///// </summary>
        ///// <param name="path"></param>
        ///// <returns></returns>
        //public static string UrlConvertor(this string path)
        //{
        //    var baseDirectory = CommonHelper.DefaultFileProvider.MapPath("/");//获取程序根目录
        //    path = path.Replace(baseDirectory, ""); //转换成相对路径
        //    path = path.Replace("~/", "").TrimStart('/').Replace('\\', '/');
        //    if (!path.StartsWith("/"))
        //        path = $"/{path}";
        //    return path;
        //}


        /// <summary>
        /// 替换文件名不可以字符
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string ReplaceInvalidPath(string fileName)
        {
            var regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            var r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            fileName = r.Replace(fileName, "");
            return fileName;
        }

        ///// <summary>
        ///// 转换amr到MP3
        ///// </summary>
        ///// <param name="armPath"></param>
        ///// <param name="mp3Path"></param>
        ///// <returns></returns>
        //public static bool ConvertAmrToMp3(string armPath, string mp3Path)
        //{
        //    var ffmpegPath = CommonHelper.DefaultFileProvider.MapPath("~/Plugins/Other.WeChatManager/Media/Tools/ffmpeg.exe");
        //    if (File.Exists(ffmpegPath))
        //    {
        //        string c = ffmpegPath + " -i " + armPath + " " + mp3Path;
        //        string str = RunCmd(c);
        //        return true;
        //    }
        //    return false;
        //}

        /// <summary>
        /// 执行Cmd命令
        /// </summary>
        private static string RunCmd(string c)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo("cmd.exe");
                info.RedirectStandardOutput = false;
                info.UseShellExecute = false;
                Process p = Process.Start(info);
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.Start();
                p.StandardInput.WriteLine(c);
                p.StandardInput.AutoFlush = true;
                Thread.Sleep(2000);
                p.StandardInput.WriteLine("exit");
                p.WaitForExit();
                string outStr = p.StandardOutput.ReadToEnd();
                p.Close();

                return outStr;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 遍历所有错误
        /// </summary>
        /// <param name="modelState"></param>
        /// <returns></returns>
        public static List<string> TraversalModelState(this ModelStateDictionary modelState)
        {
            var list = new List<string>();
            //获取每一个key对应的ModelStateDictionary
            foreach (var keyValuePair in modelState)
            {
                var errors = keyValuePair.Value.Errors;
                //将错误描述添加到sb中
                if (errors.Count == 0)
                    continue;
                var sb = new StringBuilder();
                sb.Append(string.Join(";", errors.Select(error => $"{GetError(error)}")));
                list.Add(sb.ToString());
            }
            return list;
        }

        public static string GetError(ModelError modelError)
        {
            if (!string.IsNullOrWhiteSpace(modelError.ErrorMessage))
                return modelError.ErrorMessage;
            return GetLastInnerError(modelError.Exception);
        }

        public static string GetLastInnerError(Exception e)
        {

            if (e.InnerException != null)
            {
                GetLastInnerError(e.InnerException);
            }
            return e.Message;

        }


        ///// <summary>
        ///// 文件转字节
        ///// </summary>
        ///// <param name="stream"></param>
        ///// <returns></returns>
        //public static byte[] StreamToBytes(Stream stream)
        //{
        //    byte[] bytes = new byte[stream.Length];
        //    stream.Read(bytes, 0, bytes.Length);
        //    // 设置当前流的位置为流的开始
        //    stream.Seek(0, SeekOrigin.Begin);
        //    return bytes;
        //}
        ////<[img].*?src=[\'|\"](.*?(?:[.jpg|.jpeg|.png|.gif|.bmp]))[\'|\"].*?[/]?>
        //private static readonly Regex ImgRule = new Regex("<img.*?>", RegexOptions.IgnoreCase);
        //private static readonly Regex DataSrcRule = new Regex("(?<=data-src=\"|').*?(?=\"|')", RegexOptions.IgnoreCase);
        //private static readonly Regex AllDataSrcRule = new Regex("(data-src=\"|').*?(\"|')", RegexOptions.IgnoreCase);
        //private static readonly Regex SrcRule = new Regex("(?<=src=\"|').*?(?=\"|')", RegexOptions.IgnoreCase);
        //private static readonly Regex AllSrcRule = new Regex("(src=\"|').*?(\"|')", RegexOptions.IgnoreCase);
        //private static readonly Regex BgRegex = new Regex(@"url\((&quot;|'|"")(?<url>.*?)(&quot;|'|"")\)", RegexOptions.IgnoreCase);//匹配背景图地址
        //private static readonly Regex SectionRegex = new Regex(@"<[^>]*?url[^>]*?>", RegexOptions.IgnoreCase);//匹配节
        //public static string RepleceToWxContent(string appid, string content, out string newcontent)
        //{
        //    newcontent = content;
        //    var imgs = ImgRule.Matches(content);
        //    var sections = SectionRegex.Matches(content);
        //    for (int i = 0; i < imgs.Count; i++)
        //    {
        //        var match = imgs[i];
        //        var img = match.Value;//原始url
        //        var rimg = ReplaceWxImg(appid, img, out string newstring);//微信url  url+data-url
        //        content = content.Replace(img, rimg);
        //        if (newstring != img)
        //        {
        //            newcontent = newcontent.Replace(img, newstring);
        //        }

        //    }
        //    foreach (Match section in sections)
        //    {

        //        if (!string.IsNullOrWhiteSpace(section.Value))
        //        {
        //            var wxUrl = ReplaceWxImg(appid, section.Value, out string newstring);
        //            content = content.Replace(section.Value, wxUrl);
        //            if (newstring != section.Value)
        //            {
        //                newcontent = newcontent.Replace(section.Value, newstring);
        //            }
        //        }


        //    }
        //    return content;
        //}

        //public static string ReplaceToLocationContent(string content)
        //{
        //    var imgs = ImgRule.Matches(content);
        //    var bgImages = BgRegex.Matches(content);
        //    for (int i = 0; i < imgs.Count; i++)
        //    {
        //        var match = imgs[i];
        //        var img = match.Value;
        //        var rimg = ReplaceLocationImg(img);
        //        content = content.Replace(img, rimg);

        //    }
        //    foreach (Match match in bgImages)
        //    {
        //        var url = match.Groups["url"].Value;
        //        if (!string.IsNullOrWhiteSpace(url))
        //        {
        //            var locationUrl = ReplaceBgImg(url);
        //            content = content.Replace(url, locationUrl);
        //        }
        //    }
        //    return content;
        //}


        //private static string ReplaceLocationImg(string img)
        //{
        //    var datasrc = DataSrcRule.Match(img).Value;
        //    if (!string.IsNullOrWhiteSpace(datasrc) && datasrc.StartsWith("https://mmbiz.qpic.cn"))
        //    {

        //        img = img.Replace(">", $"src=\"/Admin/WxMedia/NewsImg?wxurl={Uri.EscapeDataString(datasrc)}\">");
        //        return img;
        //    }

        //    return img;
        //}
        private static string ReplaceBgImg(string url)
        {
            if (url.StartsWith("https://mmbiz.qpic.cn"))
            {

                url = $"/Admin/WxMedia/NewsImg?wxurl={Uri.EscapeDataString(url)}";
                return url;
            }

            return url;
        }

        public static string GetEnumDescription(Enum enumValue)
        {
            string str = enumValue.ToString();
            System.Reflection.FieldInfo field = enumValue.GetType().GetField(str);
            object[] objs = field.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
            if (objs == null || objs.Length == 0) return str;
            System.ComponentModel.DescriptionAttribute da = (System.ComponentModel.DescriptionAttribute)objs[0];
            return da.Description;
        }
    }
}
