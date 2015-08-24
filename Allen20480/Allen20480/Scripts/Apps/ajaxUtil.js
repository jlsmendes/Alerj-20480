var Ajax = function (options) {
    var _url = options.url;
    var _type = options.type;
    var _dataType = options.dataType;
    var _contentType = options.contentType;
    var _data = options.data;

    this.makeRequest = function (beforeSend) {
        return $.ajax({
            url: _url,
            type: _type,
            dataType: _dataType,
            contentType: _contentType,
            data: _data,
            beforeSend: beforeSend
        }).promise();
    };
};

