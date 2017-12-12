﻿//  Copyright 2015 Stefan Negritoiu (FreeBusy). See LICENSE file for more information.

using System;

namespace AlexaSkillsKit.UI
{
    public abstract class Card
    {
        public abstract string Type {
            get;
        }

        [Obsolete("field has been deprecated from ASK and will be removed in a future version of this library")]
        public virtual string Subtitle {
            get;
            set;
        }
    }
}