using System.Text;

namespace Application
{
    public class Report
    {
        public static string GetHTMLString(ReportInput input) {
            var sb = new StringBuilder();
            
            sb.Append(@"
                <html>
                    <head></head>
                    <body>
                        <div class='header'><h1>This is the generated PDF report!!!</h1></div>
                            <table align='center'>
                                <tr>
                                    <th>Row number</th>
                                    <th>Equation</th>
                                    <th>Created at</th>
                                </tr>");
            
            int rowNumber = 1;
            foreach(CalculationRecord record in input.Records) {
                sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                  </tr>", rowNumber, record.Equation, record.CreatedAT);
            }

            sb.Append(@"
                </table>
                </body>
                </html>
            ");


            return sb.ToString();
        }

    }
}