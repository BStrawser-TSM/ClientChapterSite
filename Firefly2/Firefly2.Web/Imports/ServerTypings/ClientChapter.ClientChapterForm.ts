
namespace Firefly2.ClientChapter {
    export class ClientChapterForm extends Serenity.PrefixedContext {
        static formKey = 'ClientChapter.ClientChapter';
    }

    export interface ClientChapterForm {
        Chapter: Serenity.StringEditor;
        Tstate: Serenity.StringEditor;
        ChapName: Serenity.StringEditor;
        Iid: Serenity.StringEditor;
        AreaName: Serenity.StringEditor;
        Env1: Serenity.StringEditor;
        Env2: Serenity.StringEditor;
        Env3: Serenity.StringEditor;
        Env4: Serenity.StringEditor;
        Tname: Serenity.StringEditor;
        Taddr1: Serenity.StringEditor;
        Taddr2: Serenity.StringEditor;
        Taddr3: Serenity.StringEditor;
        Tcity: Serenity.StringEditor;
        Tzip: Serenity.StringEditor;
        Whokey: Serenity.StringEditor;
        TranDate: Serenity.StringEditor;
        Uw: Serenity.StringEditor;
        Commander: Serenity.StringEditor;
        CommTitle: Serenity.StringEditor;
        Cid: Serenity.StringEditor;
        Ctype: Serenity.StringEditor;
        Billchap: Serenity.StringEditor;
        CommLname: Serenity.StringEditor;
        Phone: Serenity.StringEditor;
        Fax: Serenity.StringEditor;
        Email: Serenity.StringEditor;
        Oldchap: Serenity.StringEditor;
        Memo: Serenity.StringEditor;
        CustNo: Serenity.StringEditor;
        Invchap: Serenity.StringEditor;
        NlTag: Serenity.StringEditor;
        Origcid: Serenity.StringEditor;
        Origiid: Serenity.StringEditor;
        Webadd: Serenity.StringEditor;
        Region: Serenity.StringEditor;
        Lockbox: Serenity.StringEditor;
        Uwblackfm: Serenity.StringEditor;
        Uwblackto: Serenity.StringEditor;
        MdCoord: Serenity.StringEditor;
        Commander2: Serenity.StringEditor;
        Commtitle2: Serenity.StringEditor;
        Commlname2: Serenity.StringEditor;
        Billchap2: Serenity.StringEditor;
        Email2: Serenity.StringEditor;
        Mspthanks: Serenity.StringEditor;
        Lastthank: Serenity.StringEditor;
        Seedname: Serenity.StringEditor;
        Env5: Serenity.StringEditor;
        Origname: Serenity.StringEditor;
        Clientname: Serenity.StringEditor;
        Chapdesig: Serenity.StringEditor;
        Division: Serenity.StringEditor;
        Active: Serenity.StringEditor;
        SiteId: Serenity.StringEditor;
        TsmEnters: Serenity.StringEditor;
        Envcity: Serenity.StringEditor;
        Envstate: Serenity.StringEditor;
        Envzip: Serenity.StringEditor;
        CreateDate: Serenity.DateEditor;
        ModifiedDate: Serenity.DateEditor;
        CreatedBy: Serenity.StringEditor;
        ModifiedBy: Serenity.StringEditor;
    }

    [,
        ['Chapter', () => Serenity.StringEditor],
        ['Tstate', () => Serenity.StringEditor],
        ['ChapName', () => Serenity.StringEditor],
        ['Iid', () => Serenity.StringEditor],
        ['AreaName', () => Serenity.StringEditor],
        ['Env1', () => Serenity.StringEditor],
        ['Env2', () => Serenity.StringEditor],
        ['Env3', () => Serenity.StringEditor],
        ['Env4', () => Serenity.StringEditor],
        ['Tname', () => Serenity.StringEditor],
        ['Taddr1', () => Serenity.StringEditor],
        ['Taddr2', () => Serenity.StringEditor],
        ['Taddr3', () => Serenity.StringEditor],
        ['Tcity', () => Serenity.StringEditor],
        ['Tzip', () => Serenity.StringEditor],
        ['Whokey', () => Serenity.StringEditor],
        ['TranDate', () => Serenity.StringEditor],
        ['Uw', () => Serenity.StringEditor],
        ['Commander', () => Serenity.StringEditor],
        ['CommTitle', () => Serenity.StringEditor],
        ['Cid', () => Serenity.StringEditor],
        ['Ctype', () => Serenity.StringEditor],
        ['Billchap', () => Serenity.StringEditor],
        ['CommLname', () => Serenity.StringEditor],
        ['Phone', () => Serenity.StringEditor],
        ['Fax', () => Serenity.StringEditor],
        ['Email', () => Serenity.StringEditor],
        ['Oldchap', () => Serenity.StringEditor],
        ['Memo', () => Serenity.StringEditor],
        ['CustNo', () => Serenity.StringEditor],
        ['Invchap', () => Serenity.StringEditor],
        ['NlTag', () => Serenity.StringEditor],
        ['Origcid', () => Serenity.StringEditor],
        ['Origiid', () => Serenity.StringEditor],
        ['Webadd', () => Serenity.StringEditor],
        ['Region', () => Serenity.StringEditor],
        ['Lockbox', () => Serenity.StringEditor],
        ['Uwblackfm', () => Serenity.StringEditor],
        ['Uwblackto', () => Serenity.StringEditor],
        ['MdCoord', () => Serenity.StringEditor],
        ['Commander2', () => Serenity.StringEditor],
        ['Commtitle2', () => Serenity.StringEditor],
        ['Commlname2', () => Serenity.StringEditor],
        ['Billchap2', () => Serenity.StringEditor],
        ['Email2', () => Serenity.StringEditor],
        ['Mspthanks', () => Serenity.StringEditor],
        ['Lastthank', () => Serenity.StringEditor],
        ['Seedname', () => Serenity.StringEditor],
        ['Env5', () => Serenity.StringEditor],
        ['Origname', () => Serenity.StringEditor],
        ['Clientname', () => Serenity.StringEditor],
        ['Chapdesig', () => Serenity.StringEditor],
        ['Division', () => Serenity.StringEditor],
        ['Active', () => Serenity.StringEditor],
        ['SiteId', () => Serenity.StringEditor],
        ['TsmEnters', () => Serenity.StringEditor],
        ['Envcity', () => Serenity.StringEditor],
        ['Envstate', () => Serenity.StringEditor],
        ['Envzip', () => Serenity.StringEditor],
        ['CreateDate', () => Serenity.DateEditor],
        ['ModifiedDate', () => Serenity.DateEditor],
        ['CreatedBy', () => Serenity.StringEditor],
        ['ModifiedBy', () => Serenity.StringEditor]
    ].forEach(x => Object.defineProperty(ClientChapterForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}