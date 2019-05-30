
namespace Firefly2.Products {
    export interface ProductsRow {
        Id?: string;
        Name?: string;
        Description?: string;
        Price?: number;
        Category?: string;
        Image?: string;
        CreatedAt?: any;
    }

    export namespace ProductsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Id';
        export const localTextPrefix = 'Products.Products';

        export namespace Fields {
            export declare const Id;
            export declare const Name;
            export declare const Description;
            export declare const Price;
            export declare const Category;
            export declare const Image;
            export declare const CreatedAt;
        }

        [
            'Id',
            'Name',
            'Description',
            'Price',
            'Category',
            'Image',
            'CreatedAt'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}