var isPrime = (function(){
    var cache = {};
    function checkPrime(n){
        console.log("processing");
        if (n <= 3) return true;
        for(var i=2; i <= (n/2); i++)
            if (n % i === 0) return false;
        return true;
    }
    return function(n){
        if (typeof cache[n] === "undefined")
            cache[n] = checkPrime(n);
        return cache[n];
    }
})()

var add = (function(){
    var cache = {};
    function add(x,y){
        console.log("processing");
        return x + y;
    }
    return function(x,y){
        var key = JSON.stringify(arguments);
        if (typeof cache[key] === "undefined")
            cache[key] = add(x,y);
        return cache[key];
    }
})()

function memorize(fn){
    var cache = {};
    return function(x,y){
        var key = JSON.stringify(arguments);
        if (typeof cache[key] === "undefined")
            cache[key] = fn.apply(this, arguments);
        return cache[key];
    }
}











