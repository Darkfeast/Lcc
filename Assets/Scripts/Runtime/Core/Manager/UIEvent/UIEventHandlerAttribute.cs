﻿using System;

namespace Model
{
    public class UIEventHandlerAttribute : Attribute
    {
        public UIEventType uiEventType;
        public UIEventHandlerAttribute(UIEventType uiEventType)
        {
            this.uiEventType = uiEventType;
        }
    }
}