import { ErrorHandler, Injector, Inject } from '@angular/core';

import * as StackTrace from 'stacktrace-js';
import { LocationStrategy, PathLocationStrategy } from '@angular/common';
import { ProdutoService, Log } from '../services/produto.service';

export class GlobalErrorHandler implements ErrorHandler {

    // locationy: LocationStrategy;

    constructor(private service: ProdutoService) {
        //const service = this.injector.get(ProdutoService);
    }

    handleError(error: any): void {
        console.log('MINHA CLASSE DE TRATAMENTO DE ERROS');

        const url = location instanceof PathLocationStrategy
            ? location.path()
            : '';

        const message = error.message
            ? error.message
            : error.toString();

        StackTrace.fromError(error)
            .then(stackFrame => {
                //   console.log(stackFrame);

                const stackAsString = stackFrame
                    .map(sf => sf.toString())
                    .join('\n');

                // console.log('url', url);
                console.log('message', message);
                console.log('stackAsString', stackAsString);


                const log: Log =
                {
                    message: message,
                    stack: stackAsString,
                    url: ' url que gerou erro',
                    usuario:'usuario logado'
                };

                //this.service.log(log);
            });

        throw Error;
    }
}
