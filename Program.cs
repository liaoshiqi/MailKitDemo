using MailKitDemo.MailKit;
using System;
using System.Collections.Generic;

namespace MailKitDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            var mailServerConfig = new SendServerConfigurationEntity()
            {
                SmtpPort = 0,                           //SMTP端口
                IsSsl = true,                           //启用Ssl
                SenderAccount = "****@qq.com",     //发件人
                SmtpHost = "smtp.qq.com",               //邮件Smtp服务，QQ：smtp.qq.com
                SenderPassword = "****",    //邮箱授权码
            };

            var mailBodyEntity = new MailBodyEntity()
            {
                Subject = "标题",
                Body = "邮件内容：<BR>百度：<a href='http://www.baidu.com'>点我</a>",
                Recipients = new List<string>() { "***@163.com"},      //收件人
                SenderAddress = "****@qq.com",     //发件人
            };
            var result = MailHelper.SendMail(mailBodyEntity, mailServerConfig);

        }
    }
}
