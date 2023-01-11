export function phoneValidator(number) {
    console.log(number);
    let regex = /^0\d{9}$|^996\d{9}$/;
    return regex.test(number);
}