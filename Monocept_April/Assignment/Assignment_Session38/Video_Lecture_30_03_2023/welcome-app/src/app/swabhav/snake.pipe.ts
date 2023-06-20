import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'snake'
})
export class SnakePipe implements PipeTransform {

  transform(inputMessage: string, casing: string = ""): unknown {
    console.log(inputMessage)
    if (casing == "U") {
      inputMessage = inputMessage.toUpperCase()
    }
    else if (casing = "L") {
      inputMessage = inputMessage.toLocaleLowerCase()
    }
    return inputMessage.split(' ').join('_')
  }

}
