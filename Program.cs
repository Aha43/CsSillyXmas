

Enumerable.Range(2, 8).Select(e => e * e).ToList().ForEach(e =>
{
    var xmasDict = new Dictionary<int, char> { { 4, 'G' }, { 9, 'o' }, { 16, 'd' }, { 25, ' ' }, { 36, 'J' }, { 49, 'u' }, { 64, 'l' }, { 81, '!' } };
    var l = xmasDict[e];
    switch (e)
    {
        case 9 * 9:
            Console.WriteLine(xmasDict[e]);
            break;
        default:
            Console.Write(xmasDict[e]);
            break;
    }
});

// > God Jul!
