
namespace Firefly2.Products {
    export class ProductsForm extends Serenity.PrefixedContext {
        static formKey = 'Products.Products';
    }

    export interface ProductsForm {
        Name: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Price: Serenity.DecimalEditor;
        Category: Serenity.StringEditor;
        Image: Serenity.StringEditor;
        CreatedAt: Serenity.StringEditor;
    }

    [,
        ['Name', () => Serenity.StringEditor],
        ['Description', () => Serenity.StringEditor],
        ['Price', () => Serenity.DecimalEditor],
        ['Category', () => Serenity.StringEditor],
        ['Image', () => Serenity.StringEditor],
        ['CreatedAt', () => Serenity.StringEditor]
    ].forEach(x => Object.defineProperty(ProductsForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}