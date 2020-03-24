export interface Result<T> {
    sucesso: boolean;
    data: T;
    erros: any;
}