using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace WebECom.Layers.Service
{
    public class EmailSenderService : IEmailSenderService
    {
        public void SendEmail()
        {
            //
            BackgroundJob.Enqueue(() => Thread.Sleep(10000));
            RecurringJob.AddOrUpdate("myrecurringjob",
                () => Thread.Sleep(10000),
                Cron.Minutely);
        }
    }

    public interface IEmailSenderService
    {
        void SendEmail();
    }
}
