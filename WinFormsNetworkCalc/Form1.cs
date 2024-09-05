namespace WinFormsNetworkCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNetzwerkBerechnen_Click(object sender, EventArgs e)
        {
            string address = txtAddress.Text;
            string cidr = cboCidr.Text;
            int nCidr = Convert.ToInt32(cidr);

            // 1. Adresse ausgeben
            long ipv4 = IPv4Helper.GetDez(address);
            string dezOctet = IPv4Helper.GetDezOctet(ipv4);
            string binOctet = IPv4Helper.GetBinOctet(ipv4);
            WriteString("Address:", dezOctet, binOctet);

            // 2. (Sub)Netzmaske
            long netmask = IPv4Helper.GetNetmaskDez(nCidr);
            dezOctet = IPv4Helper.GetDezOctet(netmask);
            binOctet = IPv4Helper.GetBinOctet(netmask);
            WriteString("Netmask:", dezOctet, binOctet);

            // 3. Wildcard
            long wildcard = IPv4Helper.GetWildcardDez(nCidr);
            dezOctet = IPv4Helper.GetDezOctet(wildcard);
            binOctet = IPv4Helper.GetBinOctet(wildcard);
            WriteString("Wildcard:", dezOctet, binOctet);

            // 4. NetAddress
            long netaddress = ipv4 & netmask;
            dezOctet = IPv4Helper.GetDezOctet(netaddress);
            binOctet = IPv4Helper.GetBinOctet(netaddress);
            WriteString("NetAddress:", dezOctet, binOctet);

            // 5. Broadcast
            long broadcast = ipv4 | wildcard;
            dezOctet = IPv4Helper.GetDezOctet(broadcast);
            binOctet = IPv4Helper.GetBinOctet(broadcast);
            WriteString("Broadcast:", dezOctet, binOctet);

            // 6. Host min
            long hostMin = netaddress + 1;
            dezOctet = IPv4Helper.GetDezOctet(hostMin);
            binOctet = IPv4Helper.GetBinOctet(hostMin);
            WriteString("Host min:", dezOctet, binOctet);

            // 7. Host max
            long hostMax = broadcast - 1;
            dezOctet = IPv4Helper.GetDezOctet(hostMax);
            binOctet = IPv4Helper.GetBinOctet(hostMax);
            WriteString("Host max:", dezOctet, binOctet);

            // 8. Hosts
            long hosts = IPv4Helper.GetHosts(nCidr);            
            WriteString("Hosts:", hosts.ToString());
        }

        // Hilfsmethode zum Schreiben einer Zeile in Listbox
        private void WriteString(string bezeichnung, 
                                string dezOctet = "", 
                                string binOctet = "")
        {
            string zeile = bezeichnung.PadLeft(15) + "  "
                            + dezOctet.PadRight(17)
                            + binOctet;

            listBox1.Items.Add(zeile);
        }
    }
}
