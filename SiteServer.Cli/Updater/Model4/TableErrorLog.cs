namespace SiteServer.Cli.Updater.Model4
{
    public static class TableErrorLog
    {
        public const string OldTableName = "bairong_ErrorLog";

        public static ConvertInfo Converter => new ConvertInfo
        {
            IsAbandon = true
        };
    }
}