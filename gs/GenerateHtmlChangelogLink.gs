function GenerateHtmlChangelogLink(url, listName) {
    if (url instanceof Array) {
        for (i in url) {
            url[i] = GenerateHtmlChangelogLink(url[i], listName[i]);
        }
        return url;
    } else {
        if (url) {
            var html = "<a href=\"" + url + "\" title=\"" + listName + " Changelog\" class=\"button\">Changelog</a>";
            return html;
        } else {
            return "";
        }
    }
}