using TextElementsAsIntroToInterface;

var header = new CenteredHeader("Overskrift", '*');
var bulletPointA = new BulletPoint("A");
var bulletPointB = new BulletPoint("B");
var bulletPointC = new BulletPoint("C");
var paragraph = new IndentedParagraph("Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. ");

var textElements = new ITextElement[]
{
    header, bulletPointA, bulletPointB, bulletPointC, paragraph
};

foreach (var element in textElements)
{
    element.Show();
}


/*

Med array - uten interface

var textElements = new object[]
{
    header, bulletPointA, bulletPointB, bulletPointC, paragraph
};

foreach (var element in textElements)
{
    if (element is CenteredHeader)
    {
        var centeredHeader = (CenteredHeader)element;
        centeredHeader.Show();
    }
    else if (element is BulletPoint)
    {
        var bulletPoint = (BulletPoint)element;
        bulletPoint.Show();
    }
    else if (element is IndentedParagraph)
    {
        var paragraph1 = (IndentedParagraph)element;
        paragraph1.Show();
    }
}
*/

//header.Show();
//bulletPointA.Show();
//bulletPointB.Show();
//bulletPointC.Show();
//paragraph.Show();