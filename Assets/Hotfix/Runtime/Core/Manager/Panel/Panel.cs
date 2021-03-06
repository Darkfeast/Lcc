﻿namespace LccHotfix
{
    public class Panel : IPanel
    {
        public PanelType Type
        {
            get; set;
        }
        public PanelState State
        {
            get; set;
        }
        public AObjectBase AObjectBase
        {
            get; set;
        }
        public bool IsExist
        {
            get
            {
                if (AObjectBase.gameObject == null)
                {
                    return false;
                }
                return true;
            }
        }
        public void OpenPanel()
        {
            if (IsExist)
            {
                State = PanelState.Open;
                AObjectBase.gameObject.SetActive(true);
            }
            else
            {
                LogUtil.Log($"Panel不存在{Type}");
            }
        }
        public void ClosePanel()
        {
            if (IsExist)
            {
                State = PanelState.Close;
                AObjectBase.gameObject.SetActive(false);
            }
            else
            {
                LogUtil.Log($"Panel不存在{Type}");
            }
        }
    }
}