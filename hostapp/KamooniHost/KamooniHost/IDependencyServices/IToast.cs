﻿namespace KamooniHost.IDependencyServices
{
    public interface IToast
    {
        void LongAlert(string message);

        void ShortAlert(string message);
    }
}