﻿public class Command
{
    public int id;
    public CommandVarietyType variety;
    public bool bexcute;
    public bool bcondition;
    public bool bfinish;
    public virtual void Execute()
    {
    }
}