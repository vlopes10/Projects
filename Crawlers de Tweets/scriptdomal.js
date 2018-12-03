var fs = require('fs');

fs.readdir(__dirname, function(err, items) {
    items.forEach((x) => {
        if(x.endsWith('.txt')){
            fs.readFile(__dirname + '\\' + x, 'utf-8', function(err, data) {
                if (err) throw err;
                
                var text = ''

                try{
                    dataJ = JSON.parse(data);
                    if(dataJ.length > 1){
                        text = dataJ[0].text;
                    }
                    else{
                        text = dataJ.text;
                    }
                }
                catch(e){
                    text = data;
                }

                text = x + ': ' + text
                console.log(text)
            });
        }
    });
});