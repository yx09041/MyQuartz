﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace MyQuartzJobs
{
    class Program
    {
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config"));
            HostFactory.Run(x =>
            {
                x.UseLog4Net();
                x.Service<ServiceRunner>();
                x.SetDescription("我的通用定时服务");//安装服务后，服务的描述
                x.SetDisplayName("MyService"); //显示名称
                x.SetServiceName("我的通用定时服务名称"); //服务名称
                x.EnablePauseAndContinue();
            });
        }
    }
}
