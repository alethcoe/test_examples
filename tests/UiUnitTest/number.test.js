const sut = require ('../../CarUI/wwwroot/js/site.js');

test('default is 10', () => {
    document.body.innerHTML = "<html><body><input type='number' id='number'></body></html>"
    var number = sut.getNumber();
    expect(number).toBe(10);
});

test('number set to 5 in html', () => {
    document.body.innerHTML = "<html><body><input type='number' id='number' value='5'></body></html>"
    var number = sut.getNumber();
    expect(number).toBe(5);
});