﻿namespace Azi.Cloud.DokanNet
{
    public class UploadStatisticInfo : AStatisticFileInfo
    {
        private UploadInfo info;

        public UploadStatisticInfo(UploadInfo info)
        {
            this.info = info;
        }

        public UploadStatisticInfo(UploadInfo info, string message)
        {
            this.info = info;
            ErrorMessage = message;
        }

        public override long Total => info.Length;

        public override string Id => info.Id;

        public override string FileName => System.IO.Path.GetFileName(info.Path);

        public override string Path => info.Path;
    }
}