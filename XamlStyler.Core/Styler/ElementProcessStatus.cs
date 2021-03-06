﻿using System;

namespace XamlStyler.Core
{
    public class ElementProcessStatus
    {
        public ContentTypeEnum ContentType
        {
            get;
            set;
        }

        public bool IsMultlineStartTag
        {
            get;
            set;
        }

        public bool IsSelfClosingElement
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
    }
}