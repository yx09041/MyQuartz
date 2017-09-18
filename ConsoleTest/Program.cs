using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ysoft.Util;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MailHelper mailsend = new MailHelper();
            mailsend.MailUserName = "1303730638@qq.com";
            mailsend.MailPassword = "ufztdwqehuztgidj";
            mailsend.MailServer = "smtp.qq.com";
            mailsend.MailName = "杨旭邮件中心";
            mailsend.Send("yx090411@163.com", "【通知】系统通知", "【通知】截止当前你共有10条待办,请尽快处理;", isBodyHtml: true, enableSsl: true);

        }
    }
}
