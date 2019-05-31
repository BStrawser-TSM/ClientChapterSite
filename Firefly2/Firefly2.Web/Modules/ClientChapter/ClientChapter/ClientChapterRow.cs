
namespace Firefly2.ClientChapter.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("ClientChapter"), Module("ClientChapter"), TableName("[cc].[ClientChapter]")]
    [DisplayName("Client Chapter"), InstanceName("Client Chapter")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ClientChapterRow : Row, IIdRow, INameRow
    {
        [DisplayName("Client Chapter S Key"), Identity]
        public Int32? ClientChapterSKey
        {
            get { return Fields.ClientChapterSKey[this]; }
            set { Fields.ClientChapterSKey[this] = value; }
        }

        [DisplayName("Chapter"), Column("chapter")]
        public String Chapter
        {
            get { return Fields.Chapter[this]; }
            set { Fields.Chapter[this] = value; }
        }

        [DisplayName("Tstate"), Column("tstate"), QuickSearch]
        public String Tstate
        {
            get { return Fields.Tstate[this]; }
            set { Fields.Tstate[this] = value; }
        }

        [DisplayName("Chap Name"), Column("chap_name")]
        public String ChapName
        {
            get { return Fields.ChapName[this]; }
            set { Fields.ChapName[this] = value; }
        }

        [DisplayName("Iid"), Column("iid")]
        public String Iid
        {
            get { return Fields.Iid[this]; }
            set { Fields.Iid[this] = value; }
        }

        [DisplayName("Area Name"), Column("area_name")]
        public String AreaName
        {
            get { return Fields.AreaName[this]; }
            set { Fields.AreaName[this] = value; }
        }

        [DisplayName("Env1"), Column("env1")]
        public String Env1
        {
            get { return Fields.Env1[this]; }
            set { Fields.Env1[this] = value; }
        }

        [DisplayName("Env2"), Column("env2")]
        public String Env2
        {
            get { return Fields.Env2[this]; }
            set { Fields.Env2[this] = value; }
        }

        [DisplayName("Env3"), Column("env3")]
        public String Env3
        {
            get { return Fields.Env3[this]; }
            set { Fields.Env3[this] = value; }
        }

        [DisplayName("Env4"), Column("env4")]
        public String Env4
        {
            get { return Fields.Env4[this]; }
            set { Fields.Env4[this] = value; }
        }

        [DisplayName("Tname"), Column("tname")]
        public String Tname
        {
            get { return Fields.Tname[this]; }
            set { Fields.Tname[this] = value; }
        }

        [DisplayName("Taddr1"), Column("taddr1")]
        public String Taddr1
        {
            get { return Fields.Taddr1[this]; }
            set { Fields.Taddr1[this] = value; }
        }

        [DisplayName("Taddr2"), Column("taddr2")]
        public String Taddr2
        {
            get { return Fields.Taddr2[this]; }
            set { Fields.Taddr2[this] = value; }
        }

        [DisplayName("Taddr3"), Column("taddr3")]
        public String Taddr3
        {
            get { return Fields.Taddr3[this]; }
            set { Fields.Taddr3[this] = value; }
        }

        [DisplayName("Tcity"), Column("tcity")]
        public String Tcity
        {
            get { return Fields.Tcity[this]; }
            set { Fields.Tcity[this] = value; }
        }

        [DisplayName("Tzip"), Column("tzip")]
        public String Tzip
        {
            get { return Fields.Tzip[this]; }
            set { Fields.Tzip[this] = value; }
        }

        [DisplayName("Whokey"), Column("whokey")]
        public String Whokey
        {
            get { return Fields.Whokey[this]; }
            set { Fields.Whokey[this] = value; }
        }

        [DisplayName("Tran Date"), Column("tran_date")]
        public String TranDate
        {
            get { return Fields.TranDate[this]; }
            set { Fields.TranDate[this] = value; }
        }

        [DisplayName("Uw"), Column("uw")]
        public String Uw
        {
            get { return Fields.Uw[this]; }
            set { Fields.Uw[this] = value; }
        }

        [DisplayName("Commander"), Column("commander")]
        public String Commander
        {
            get { return Fields.Commander[this]; }
            set { Fields.Commander[this] = value; }
        }

        [DisplayName("Comm Title"), Column("comm_title")]
        public String CommTitle
        {
            get { return Fields.CommTitle[this]; }
            set { Fields.CommTitle[this] = value; }
        }

        [DisplayName("Cid"), Column("cid")]
        public String Cid
        {
            get { return Fields.Cid[this]; }
            set { Fields.Cid[this] = value; }
        }

        [DisplayName("Ctype"), Column("ctype")]
        public String Ctype
        {
            get { return Fields.Ctype[this]; }
            set { Fields.Ctype[this] = value; }
        }

        [DisplayName("Billchap"), Column("billchap")]
        public String Billchap
        {
            get { return Fields.Billchap[this]; }
            set { Fields.Billchap[this] = value; }
        }

        [DisplayName("Comm Lname"), Column("comm_lname")]
        public String CommLname
        {
            get { return Fields.CommLname[this]; }
            set { Fields.CommLname[this] = value; }
        }

        [DisplayName("Phone"), Column("phone")]
        public String Phone
        {
            get { return Fields.Phone[this]; }
            set { Fields.Phone[this] = value; }
        }

        [DisplayName("Fax"), Column("fax")]
        public String Fax
        {
            get { return Fields.Fax[this]; }
            set { Fields.Fax[this] = value; }
        }

        [DisplayName("Email"), Column("email")]
        public String Email
        {
            get { return Fields.Email[this]; }
            set { Fields.Email[this] = value; }
        }

        [DisplayName("Oldchap"), Column("oldchap")]
        public String Oldchap
        {
            get { return Fields.Oldchap[this]; }
            set { Fields.Oldchap[this] = value; }
        }

        [DisplayName("Memo"), Column("memo")]
        public String Memo
        {
            get { return Fields.Memo[this]; }
            set { Fields.Memo[this] = value; }
        }

        [DisplayName("Cust No"), Column("cust_no")]
        public String CustNo
        {
            get { return Fields.CustNo[this]; }
            set { Fields.CustNo[this] = value; }
        }

        [DisplayName("Invchap"), Column("invchap")]
        public String Invchap
        {
            get { return Fields.Invchap[this]; }
            set { Fields.Invchap[this] = value; }
        }

        [DisplayName("Nl Tag"), Column("nl_tag")]
        public String NlTag
        {
            get { return Fields.NlTag[this]; }
            set { Fields.NlTag[this] = value; }
        }

        [DisplayName("Origcid"), Column("origcid")]
        public String Origcid
        {
            get { return Fields.Origcid[this]; }
            set { Fields.Origcid[this] = value; }
        }

        [DisplayName("Origiid"), Column("origiid")]
        public String Origiid
        {
            get { return Fields.Origiid[this]; }
            set { Fields.Origiid[this] = value; }
        }

        [DisplayName("Webadd"), Column("webadd")]
        public String Webadd
        {
            get { return Fields.Webadd[this]; }
            set { Fields.Webadd[this] = value; }
        }

        [DisplayName("Region"), Column("region")]
        public String Region
        {
            get { return Fields.Region[this]; }
            set { Fields.Region[this] = value; }
        }

        [DisplayName("Lockbox"), Column("lockbox")]
        public String Lockbox
        {
            get { return Fields.Lockbox[this]; }
            set { Fields.Lockbox[this] = value; }
        }

        [DisplayName("Uwblackfm"), Column("uwblackfm")]
        public String Uwblackfm
        {
            get { return Fields.Uwblackfm[this]; }
            set { Fields.Uwblackfm[this] = value; }
        }

        [DisplayName("Uwblackto"), Column("uwblackto")]
        public String Uwblackto
        {
            get { return Fields.Uwblackto[this]; }
            set { Fields.Uwblackto[this] = value; }
        }

        [DisplayName("Md Coord"), Column("md_coord")]
        public String MdCoord
        {
            get { return Fields.MdCoord[this]; }
            set { Fields.MdCoord[this] = value; }
        }

        [DisplayName("Commander2"), Column("commander2")]
        public String Commander2
        {
            get { return Fields.Commander2[this]; }
            set { Fields.Commander2[this] = value; }
        }

        [DisplayName("Commtitle2"), Column("commtitle2")]
        public String Commtitle2
        {
            get { return Fields.Commtitle2[this]; }
            set { Fields.Commtitle2[this] = value; }
        }

        [DisplayName("Commlname2"), Column("commlname2")]
        public String Commlname2
        {
            get { return Fields.Commlname2[this]; }
            set { Fields.Commlname2[this] = value; }
        }

        [DisplayName("Billchap2"), Column("billchap2")]
        public String Billchap2
        {
            get { return Fields.Billchap2[this]; }
            set { Fields.Billchap2[this] = value; }
        }

        [DisplayName("Email2"), Column("email2")]
        public String Email2
        {
            get { return Fields.Email2[this]; }
            set { Fields.Email2[this] = value; }
        }

        [DisplayName("Mspthanks"), Column("mspthanks")]
        public String Mspthanks
        {
            get { return Fields.Mspthanks[this]; }
            set { Fields.Mspthanks[this] = value; }
        }

        [DisplayName("Lastthank"), Column("lastthank")]
        public String Lastthank
        {
            get { return Fields.Lastthank[this]; }
            set { Fields.Lastthank[this] = value; }
        }

        [DisplayName("Seedname"), Column("seedname")]
        public String Seedname
        {
            get { return Fields.Seedname[this]; }
            set { Fields.Seedname[this] = value; }
        }

        [DisplayName("Env5"), Column("env5")]
        public String Env5
        {
            get { return Fields.Env5[this]; }
            set { Fields.Env5[this] = value; }
        }

        [DisplayName("Origname"), Column("origname")]
        public String Origname
        {
            get { return Fields.Origname[this]; }
            set { Fields.Origname[this] = value; }
        }

        [DisplayName("Clientname"), Column("clientname")]
        public String Clientname
        {
            get { return Fields.Clientname[this]; }
            set { Fields.Clientname[this] = value; }
        }

        [DisplayName("Chapdesig"), Column("chapdesig")]
        public String Chapdesig
        {
            get { return Fields.Chapdesig[this]; }
            set { Fields.Chapdesig[this] = value; }
        }

        [DisplayName("Division"), Column("division")]
        public String Division
        {
            get { return Fields.Division[this]; }
            set { Fields.Division[this] = value; }
        }

        [DisplayName("Active"), Column("active")]
        public String Active
        {
            get { return Fields.Active[this]; }
            set { Fields.Active[this] = value; }
        }

        [DisplayName("Site Id"), Column("site_id")]
        public String SiteId
        {
            get { return Fields.SiteId[this]; }
            set { Fields.SiteId[this] = value; }
        }

        [DisplayName("Tsm Enters"), Column("tsm_enters")]
        public String TsmEnters
        {
            get { return Fields.TsmEnters[this]; }
            set { Fields.TsmEnters[this] = value; }
        }

        [DisplayName("Envcity"), Column("envcity")]
        public String Envcity
        {
            get { return Fields.Envcity[this]; }
            set { Fields.Envcity[this] = value; }
        }

        [DisplayName("Envstate"), Column("envstate")]
        public String Envstate
        {
            get { return Fields.Envstate[this]; }
            set { Fields.Envstate[this] = value; }
        }

        [DisplayName("Envzip"), Column("envzip")]
        public String Envzip
        {
            get { return Fields.Envzip[this]; }
            set { Fields.Envzip[this] = value; }
        }

        //[DisplayName("Create Date")]
        //public DateTime? CreateDate
        //{
        //    get { return Fields.CreateDate[this]; }
        //    set { Fields.CreateDate[this] = value; }
        //}

        //[DisplayName("Modified Date")]
        //public DateTime? ModifiedDate
        //{
        //    get { return Fields.ModifiedDate[this]; }
        //    set { Fields.ModifiedDate[this] = value; }
        //}

        //[DisplayName("Created By"), Size(50)]
        //public String CreatedBy
        //{
        //    get { return Fields.CreatedBy[this]; }
        //    set { Fields.CreatedBy[this] = value; }
        //}

        //[DisplayName("Modified By"), Size(50)]
        //public String ModifiedBy
        //{
        //    get { return Fields.ModifiedBy[this]; }
        //    set { Fields.ModifiedBy[this] = value; }
        //}

        IIdField IIdRow.IdField
        {
            get { return Fields.ClientChapterSKey; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Chapter; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ClientChapterRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ClientChapterSKey;
            public StringField Chapter;
            public StringField Tstate;
            public StringField ChapName;
            public StringField Iid;
            public StringField AreaName;
            public StringField Env1;
            public StringField Env2;
            public StringField Env3;
            public StringField Env4;
            public StringField Tname;
            public StringField Taddr1;
            public StringField Taddr2;
            public StringField Taddr3;
            public StringField Tcity;
            public StringField Tzip;
            public StringField Whokey;
            public StringField TranDate;
            public StringField Uw;
            public StringField Commander;
            public StringField CommTitle;
            public StringField Cid;
            public StringField Ctype;
            public StringField Billchap;
            public StringField CommLname;
            public StringField Phone;
            public StringField Fax;
            public StringField Email;
            public StringField Oldchap;
            public StringField Memo;
            public StringField CustNo;
            public StringField Invchap;
            public StringField NlTag;
            public StringField Origcid;
            public StringField Origiid;
            public StringField Webadd;
            public StringField Region;
            public StringField Lockbox;
            public StringField Uwblackfm;
            public StringField Uwblackto;
            public StringField MdCoord;
            public StringField Commander2;
            public StringField Commtitle2;
            public StringField Commlname2;
            public StringField Billchap2;
            public StringField Email2;
            public StringField Mspthanks;
            public StringField Lastthank;
            public StringField Seedname;
            public StringField Env5;
            public StringField Origname;
            public StringField Clientname;
            public StringField Chapdesig;
            public StringField Division;
            public StringField Active;
            public StringField SiteId;
            public StringField TsmEnters;
            public StringField Envcity;
            public StringField Envstate;
            public StringField Envzip;
        }
    }
}
