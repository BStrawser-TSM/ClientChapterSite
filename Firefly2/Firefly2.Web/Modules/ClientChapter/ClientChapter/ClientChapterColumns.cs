
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
        [EditLink]
        public String Tstate { get; set; }
        [EditLink]
        public String ChapName { get; set; }
        [EditLink]
        public String Iid { get; set; }
        [EditLink]
        public String AreaName { get; set; }
        [EditLink]
        public String Env1 { get; set; }
        [EditLink]
        public String Env2 { get; set; }
        [EditLink]
        public String Env3 { get; set; }
        [EditLink]
        public String Env4 { get; set; }
        [EditLink]
        public String Tname { get; set; }
        [EditLink]
        public String Taddr1 { get; set; }
        [EditLink]
        public String Taddr2 { get; set; }
        [EditLink]
        public String Taddr3 { get; set; }
        [EditLink]
        public String Tcity { get; set; }
        [EditLink]
        public String Tzip { get; set; }
        [EditLink]
        public String Whokey { get; set; }
        [EditLink]
        public String TranDate { get; set; }
        [EditLink]
        public String Uw { get; set; }
        [EditLink]
        public String Commander { get; set; }
        [EditLink]
        public String CommTitle { get; set; }
        [EditLink]
        public String Cid { get; set; }
        [EditLink]
        public String Ctype { get; set; }
        [EditLink]
        public String Billchap { get; set; }
        [EditLink]
        public String CommLname { get; set; }
        [EditLink]
        public String Phone { get; set; }
        [EditLink]
        public String Fax { get; set; }
        [EditLink]
        public String Email { get; set; }
        [EditLink]
        public String Oldchap { get; set; }
        [EditLink]
        public String Memo { get; set; }
        [EditLink]
        public String CustNo { get; set; }
        [EditLink]
        public String Invchap { get; set; }
        [EditLink]
        public String NlTag { get; set; }
        [EditLink]
        public String Origcid { get; set; }
        [EditLink]
        public String Origiid { get; set; }
        [EditLink]
        public String Webadd { get; set; }
        [EditLink]
        public String Region { get; set; }
        [EditLink]
        public String Lockbox { get; set; }
        [EditLink]
        public String Uwblackfm { get; set; }
        [EditLink]
        public String Uwblackto { get; set; }
        [EditLink]
        public String MdCoord { get; set; }
        [EditLink]
        public String Commander2 { get; set; }
        [EditLink]
        public String Commtitle2 { get; set; }
        [EditLink]
        public String Commlname2 { get; set; }
        [EditLink]
        public String Billchap2 { get; set; }
        [EditLink]
        public String Email2 { get; set; }
        [EditLink]
        public String Mspthanks { get; set; }
        [EditLink]
        public String Lastthank { get; set; }
        [EditLink]
        public String Seedname { get; set; }
        [EditLink]
        public String Env5 { get; set; }
        [EditLink]
        public String Origname { get; set; }
        [EditLink]
        public String Clientname { get; set; }
        [EditLink]
        public String Chapdesig { get; set; }
        [EditLink]
        public String Division { get; set; }
        [EditLink]
        public String Active { get; set; }
        [EditLink]
        public String SiteId { get; set; }
        [EditLink]
        public String TsmEnters { get; set; }
        [EditLink]
        public String Envcity { get; set; }
        [EditLink]
        public String Envstate { get; set; }
        [EditLink]
        public String Envzip { get; set; }
    }
}