﻿using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Firefly2.Common
{
    public partial class EnumSelectFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "Firefly2.Common.EnumSelectFormatter";

        public EnumSelectFormatterAttribute()
            : base(Key)
        {
        }

        public Boolean AllowClear
        {
            get { return GetOption<Boolean>("allowClear"); }
            set { SetOption("allowClear", value); }
        }

        public String EmptyItemText
        {
            get { return GetOption<String>("emptyItemText"); }
            set { SetOption("emptyItemText", value); }
        }

        public String EnumKey
        {
            get { return GetOption<String>("enumKey"); }
            set { SetOption("enumKey", value); }
        }
    }
}

