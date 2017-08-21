using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BidBuddy1
{
    class Presto
    {
        public int[] QIDs;
        public bool parseComplete = false;
        
        public string entry = "http://www.prestoexperts.com/post-request/view-requests.aspx";
       
        public void Prepare() {
            parseComplete = false;
            QIDs = new int[21];
        }


        internal int parse(string p)
        {
            if (parseComplete) return 0;
            int quest1 = p.IndexOf("?QID=");
            if (quest1 > 1000) quest1 -= 256;
            int quest1e = p.IndexOf("bottom-table") - 300; //100 is reduced to avoid extra </table> used
            return parse2(p.Substring(quest1,(quest1e-quest1)));

        }

        internal int parse2(string p) {
            p = p.Remove(p.IndexOf("</table>"));
            string[] tokens = p.Split(new[] { "href=" }, StringSplitOptions.None);
            int tc = tokens.Count();
            
            for (int i = 1; i < tc; i++) {
                QIDs[i] = token2qid(tokens[i]);
            }
            parseComplete = true;
            return 0;
        }
        //SANPLE LINE "\"/post-request/answers-list.aspx?QID=1202119\">Request for expert service in Databases</a>\r\n                                            <br />\r\n                                            <span id=\"ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_rptPBQuestions_ctl01_lblSubject\">programming assignments</span>\r\n                                        </td>\r\n                                        <td align=\"left\" class=\"qstTblContent td-border-sparator\">\r\n                                            \r\n                                        </td>\r\n                                        <td class=\"separator\"></td>\r\n                                        <td align=\"left\" class=\"qstTblContent td-border-sparator\" >\r\n                                            <span id=\"ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_rptPBQuestions_ctl01_lblCategories\">Computers & Programming : Databases (PrestoExperts)</span>\r\n                                        </td>\r\n                                        <td class=\"separator\"></td>\r\n                                        <td align=\"center\" class=\"qstTblContent td-border-sparator fee-blue\">\r\n                                            <span id=\"ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_rptPBQuestions_ctl01_lblSuggestFee\">Negotiable</span>\r\n                                        </td>\r\n                                        <td class=\"separator\"></td>\r\n                                          <td align=\"center\" class=\"qstTblContent td-border-sparator\">\r\n                                            <span id=\"ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_rptPBQuestions_ctl01_lblStartTime\"><div >August</div><div class='lblExpires'>20</div><div>2017</div></span>\r\n                                        </td>\r\n                                       <td class=\"separator\"></td>\r\n                                        <td align=\"center\" class=\"qstTblContent\" >\r\n                                            <div>Expires in</div>\r\n                                            <div><span id=\"ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_rptPBQuestions_ctl01_lblExpires\" class=\"lblExpires\">7</span></div>\r\n                                            <div>days</div>\r\n                                        </td>\r\n                                    </tr>\r\n                                \r\n                                    <tr style=\"height: 57px\" class=\"evenRow\">\r\n                                      \r\n                                        <td align=\"left\" class=\"qstTblContent td-border-sparator\">\r\n                                            <a id=\"ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_rptPBQuestions_ctl02_hlSubject\" class=\"strong\" "
        private int token2qid(string p)
        {
            int i1 = p.IndexOf("?QID=");
           string q1 = p.Substring(i1+5,7);
            int qid =  Convert.ToInt32(q1);
         //   onValidQID(qid);
            return qid;
        }



        private void onValidQID(int qid)
        {
            string lnk = MakeLink(qid);
            System.Diagnostics.Process.Start(lnk);
            
        }

        public string MakeLink(int qid)
        {
            string lnk = "http://www.prestoexperts.com/post-request/answers-list.aspx?QID=" + Convert.ToString(qid);
            return lnk;
        }

    }

}
