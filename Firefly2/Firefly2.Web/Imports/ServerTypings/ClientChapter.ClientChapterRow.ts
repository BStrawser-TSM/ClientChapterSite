
namespace Firefly2.ClientChapter {
    export interface ClientChapterRow {
        ClientChapterSKey?: number;
        Chapter?: string;
        Tstate?: string;
        ChapName?: string;
        Iid?: string;
        AreaName?: string;
        Env1?: string;
        Env2?: string;
        Env3?: string;
        Env4?: string;
        Tname?: string;
        Taddr1?: string;
        Taddr2?: string;
        Taddr3?: string;
        Tcity?: string;
        Tzip?: string;
        Whokey?: string;
        TranDate?: string;
        Uw?: string;
        Commander?: string;
        CommTitle?: string;
        Cid?: string;
        Ctype?: string;
        Billchap?: string;
        CommLname?: string;
        Phone?: string;
        Fax?: string;
        Email?: string;
        Oldchap?: string;
        Memo?: string;
        CustNo?: string;
        Invchap?: string;
        NlTag?: string;
        Origcid?: string;
        Origiid?: string;
        Webadd?: string;
        Region?: string;
        Lockbox?: string;
        Uwblackfm?: string;
        Uwblackto?: string;
        MdCoord?: string;
        Commander2?: string;
        Commtitle2?: string;
        Commlname2?: string;
        Billchap2?: string;
        Email2?: string;
        Mspthanks?: string;
        Lastthank?: string;
        Seedname?: string;
        Env5?: string;
        Origname?: string;
        Clientname?: string;
        Chapdesig?: string;
        Division?: string;
        Active?: string;
        SiteId?: string;
        TsmEnters?: string;
        Envcity?: string;
        Envstate?: string;
        Envzip?: string;
        CreateDate?: string;
        ModifiedDate?: string;
        CreatedBy?: string;
        ModifiedBy?: string;
    }

    export namespace ClientChapterRow {
        export const idProperty = 'ClientChapterSKey';
        export const nameProperty = 'Chapter';
        export const localTextPrefix = 'ClientChapter.ClientChapter';

        export namespace Fields {
            export declare const ClientChapterSKey;
            export declare const Chapter;
            export declare const Tstate;
            export declare const ChapName;
            export declare const Iid;
            export declare const AreaName;
            export declare const Env1;
            export declare const Env2;
            export declare const Env3;
            export declare const Env4;
            export declare const Tname;
            export declare const Taddr1;
            export declare const Taddr2;
            export declare const Taddr3;
            export declare const Tcity;
            export declare const Tzip;
            export declare const Whokey;
            export declare const TranDate;
            export declare const Uw;
            export declare const Commander;
            export declare const CommTitle;
            export declare const Cid;
            export declare const Ctype;
            export declare const Billchap;
            export declare const CommLname;
            export declare const Phone;
            export declare const Fax;
            export declare const Email;
            export declare const Oldchap;
            export declare const Memo;
            export declare const CustNo;
            export declare const Invchap;
            export declare const NlTag;
            export declare const Origcid;
            export declare const Origiid;
            export declare const Webadd;
            export declare const Region;
            export declare const Lockbox;
            export declare const Uwblackfm;
            export declare const Uwblackto;
            export declare const MdCoord;
            export declare const Commander2;
            export declare const Commtitle2;
            export declare const Commlname2;
            export declare const Billchap2;
            export declare const Email2;
            export declare const Mspthanks;
            export declare const Lastthank;
            export declare const Seedname;
            export declare const Env5;
            export declare const Origname;
            export declare const Clientname;
            export declare const Chapdesig;
            export declare const Division;
            export declare const Active;
            export declare const SiteId;
            export declare const TsmEnters;
            export declare const Envcity;
            export declare const Envstate;
            export declare const Envzip;
            export declare const CreateDate;
            export declare const ModifiedDate;
            export declare const CreatedBy;
            export declare const ModifiedBy;
        }

        [
            'ClientChapterSKey',
            'Chapter',
            'Tstate',
            'ChapName',
            'Iid',
            'AreaName',
            'Env1',
            'Env2',
            'Env3',
            'Env4',
            'Tname',
            'Taddr1',
            'Taddr2',
            'Taddr3',
            'Tcity',
            'Tzip',
            'Whokey',
            'TranDate',
            'Uw',
            'Commander',
            'CommTitle',
            'Cid',
            'Ctype',
            'Billchap',
            'CommLname',
            'Phone',
            'Fax',
            'Email',
            'Oldchap',
            'Memo',
            'CustNo',
            'Invchap',
            'NlTag',
            'Origcid',
            'Origiid',
            'Webadd',
            'Region',
            'Lockbox',
            'Uwblackfm',
            'Uwblackto',
            'MdCoord',
            'Commander2',
            'Commtitle2',
            'Commlname2',
            'Billchap2',
            'Email2',
            'Mspthanks',
            'Lastthank',
            'Seedname',
            'Env5',
            'Origname',
            'Clientname',
            'Chapdesig',
            'Division',
            'Active',
            'SiteId',
            'TsmEnters',
            'Envcity',
            'Envstate',
            'Envzip',
            'CreateDate',
            'ModifiedDate',
            'CreatedBy',
            'ModifiedBy'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}