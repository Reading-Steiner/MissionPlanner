using System;
using System.Reflection;
using log4net.Appender;
using log4net.Core;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using MissionPlanner.Utilities;

namespace ParameterMetaDataGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine(
                    "Usage: ParameterMetaDataGenerator.exe \"ArduCopter\\Parameters.cpp;ArduPlane\\Parameters.cpp;APMrover2\\Parameters.cpp\" output.xml");
                return;
            }


            log4net.Repository.Hierarchy.Hierarchy hierarchy =
                (Hierarchy)log4net.LogManager.GetRepository(Assembly.GetAssembly(typeof(Program)));

            PatternLayout patternLayout = new PatternLayout();
            patternLayout.ConversionPattern = "%newline %n记录时间：%date %n线程ID:[%thread] %n日志级别：  %-5level %n出错类：%logger property: [%property{NDC}] - %n错误描述：%message%newline %n";
            patternLayout.ActivateOptions();

            var cca = new RollingFileAppender();
            cca.File = "log\\";
            cca.AppendToFile = true;
            cca.RollingStyle = RollingFileAppender.RollingMode.Date;
            cca.DatePattern = "yyyy\\yyyyMM\\yyyyMMdd'.txt'";
            cca.StaticLogFileName = false;
            cca.Layout = patternLayout;
            cca.ActivateOptions();
            hierarchy.Root.AddAppender(cca);

            hierarchy.Root.Level = Level.Error;
            hierarchy.Configured = true;

            ParameterMetaDataParser.GetParameterInformation(args[0], args[1]);
        }
    }
}
