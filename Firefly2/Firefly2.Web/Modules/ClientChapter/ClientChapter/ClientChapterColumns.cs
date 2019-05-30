
namespace Firefly2.ClientChapter.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("ClientChapter.ClientChapter")]
    [BasedOnRow(typeof(Entities.ClientChapterRow), CheckNames = true)]
    public class ClientChapterColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ClientChapterSKey { get; set; }
        [EditLink]
        public String Chapter { get; set; }
        public String Tstate { get; set; }
        public String ChapName { get; set; }
        public String Iid { get; set; }
        public String AreaName { get; set; }
        public String Env1 { get; set; }
        public String Env2 { get; set; }
        public String Env3 { get; set; }
        public String Env4 { get; set; }
        public String Tname { get; set; }
        public String Taddr1 { get; set; }
        public String Taddr2 { get; set; }
        public String Taddr3 { get; set; }
        public String Tcity { get; set; }
        public String Tzip { get; set; }
        public String Whokey { get; set; }
        public String TranDate { get; set; }
        public String Uw { get; set; }
        public String Commander { get; set; }
        public String CommTitle { get; set; }
        public String Cid { get; set; }
        public String Ctype { get; set; }
        public String Billchap { get; set; }
        public String CommLname { get; set; }
        public String Phone { get; set; }
        public String Fax { get; set; }
        public String Email { get; set; }
        public String Oldchap { get; set; }
        public String Memo { get; set; }
        public String CustNo { get; set; }
        public String Invchap { get; set; }
        public String NlTag { get; set; }
        public String Origcid { get; set; }
        public String Origiid { get; set; }
        public String Webadd { get; set; }
        public String Region { get; set; }
        public String Lockbox { get; set; }
        public String Uwblackfm { get; set; }
        public String Uwblackto { get; set; }
        public String MdCoord { get; set; }
        public String Commander2 { get; set; }
        public String Commtitle2 { get; set; }
        public String Commlname2 { get; set; }
        public String Billchap2 { get; set; }
        public String Email2 { get; set; }
        public String Mspthanks { get; set; }
        public String Lastthank { get; set; }
        public String Seedname { get; set; }
        public String Env5 { get; set; }
        public String Origname { get; set; }
        public String Clientname { get; set; }
        public String Chapdesig { get; set; }
        public String Division { get; set; }
        public String Active { get; set; }
        public String SiteId { get; set; }
        public String TsmEnters { get; set; }
        public String Envcity { get; set; }
        public String Envstate { get; set; }
        public String Envzip { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public String CreatedBy { get; set; }
        public String ModifiedBy { get; set; }
    }
}