﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroLog.Internal;

namespace MetroLog.Layouts
{
    public class SingleLineLayout : Layout
    {
        public override string GetFormattedString(LogWriteContext context, LogEventInfo info)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(info.SequenceID);
            builder.Append("|");
            builder.Append(info.TimeStamp.ToString(LogManagerBase.DateTimeFormat));
            builder.Append("|");
            builder.Append(info.Level.ToString().ToUpper());
            builder.Append("|");
            builder.Append(Environment.CurrentManagedThreadId);
            builder.Append("|");
            builder.Append(info.Logger);
            builder.Append("|");
            builder.Append(info.Message);
            if (info.Exception != null)
            {
                builder.Append(" --> ");
                builder.Append(info.Exception);
            }

            return builder.ToString();
        }
    }
}
