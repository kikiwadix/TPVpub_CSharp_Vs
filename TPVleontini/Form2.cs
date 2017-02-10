using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TPVleontini
{
    public partial class Form2 : Form
    {

        Double cocaCola = 2.1, fantaNaranja = 2.1, fantaLimon = 2.1, sprite = 2.1, aquarius = 2.1, nestea = 2.1, schweppes = 2.1, zumoNaranja = 1.9, zumoPina = 1.9, zumoMelocoton = 1.9;
        Double cafeSolo = 1.2, cafeLeche = 1.5, cafeCortado = 1.5, cafeCapuchino = 2.0, cafeIrlandes = 3.5;
        Double ballantines = 3.7, jb = 3.7, brugal = 4.1, cacique = 3.7, vodka = 3.7, beefeater = 3.7, tanqueray = 4.1, jagger = 2.2, licor43 = 1.9, ruavieja = 2.0;
        Double cervezaCana = 2.0, cervezaJarra = 3.5, cervezaNegra = 3.9, cervezaTercioNacional = 2.2, cervezaTercioExportacion = 2.5;
        Double patatasLays = 1.0, patatasCheetos = 1.0, patatasKiki = 1.5, patatasFritos = 1.0, patatasTradicionales = 1.3;
        Double cacahuetes = 1.0, pipas = 1.0, pistachos = 2.0, aceitunas = 1.0, gominolas = 1.0;
        Double marlboro = 5.0, puro = 2.0, puritos = 1.4;

        Double suma = 0.0, vueltaCalculada = 0.0;

        ArrayList listaImprimir = new ArrayList();
        Double totalUltimaCuenta = 0;
        int arrayItems = 0;


        public Form2()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
            tabRefrescos.ImageIndex = 1;
            tabAlcoholes.ImageIndex = 0;
            tabSnacks.ImageIndex = 2;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

            MessageBox.Show("Time to go home! See you tomorrow!");
            Application.Exit();


        }

        private void btnCocacola_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "CocaCola 22cl = " + cocaCola);
            suma = (Double.Parse(tbTotal.Text)) + cocaCola;
            tbTotal.Text = (suma.ToString());
            
        }

        private void btnFantaNaranja_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Fanta Naranja 22cl = " + fantaNaranja);
            suma = (Double.Parse(tbTotal.Text)) + fantaNaranja;
            tbTotal.Text = (suma.ToString());
        }

        private void btnFantaLimon_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Fanta Limón 22cl = " + fantaLimon);
            suma = (Double.Parse(tbTotal.Text)) + fantaLimon;
            tbTotal.Text = (suma.ToString());
        }

        private void btnSprite_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Sprite 22cl = " + sprite);
            suma = (Double.Parse(tbTotal.Text)) + sprite;
            tbTotal.Text = (suma.ToString());
        }

        private void btnAquarius_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Aquarius 30cl = " + aquarius);
            suma = (Double.Parse(tbTotal.Text)) + aquarius;
            tbTotal.Text = (suma.ToString());
        }

        private void btnNestea_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Nestea 25cl = " + nestea);
            suma = (Double.Parse(tbTotal.Text)) + nestea;
            tbTotal.Text = (suma.ToString());
        }

        private void btnSchweppes_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Tónica Schweppes 25cl = " + schweppes);
            suma = (Double.Parse(tbTotal.Text)) + schweppes;
            tbTotal.Text = (suma.ToString());
        }

        private void btnZumoNaranja_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Zumo de Naranja 25cl = " + zumoNaranja);
            suma = (Double.Parse(tbTotal.Text)) + zumoNaranja;
            tbTotal.Text = (suma.ToString());
        }

        private void btnZumoPina_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Zumo de Piña 25cl = " + zumoPina);
            suma = (Double.Parse(tbTotal.Text)) + zumoPina;
            tbTotal.Text = (suma.ToString());
        }

        private void btnZumoMelocoton_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Zumo de Melocotón 25cl = " + zumoMelocoton);
            suma = (Double.Parse(tbTotal.Text)) + zumoMelocoton;
            tbTotal.Text = (suma.ToString());
        }

        private void btnCafeSolo_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Café Sólo = " + cafeSolo);
            suma = (Double.Parse(tbTotal.Text)) + cafeSolo;
            tbTotal.Text = (suma.ToString());
        }

        private void btnCafeLeche_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Café con Leche = " + cafeLeche);
            suma = (Double.Parse(tbTotal.Text)) + cafeLeche;
            tbTotal.Text = (suma.ToString());
        }

        private void btnCafeCortado_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Café Cortado = " + cafeCortado);
            suma = (Double.Parse(tbTotal.Text)) + cafeCortado;
            tbTotal.Text = (suma.ToString());
        }

        private void btnCafeCapuchino_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Café Capucchino = " + cafeCapuchino);
            suma = (Double.Parse(tbTotal.Text)) + cafeCapuchino;
            tbTotal.Text = (suma.ToString());
        }

        private void btnCafeIrlandes_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Café Irlandés = " + cafeIrlandes);
            suma = (Double.Parse(tbTotal.Text)) + cafeIrlandes;
            tbTotal.Text = (suma.ToString());
        }

        private void btnBallantines_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Whisky Ballantines 5cl = " + ballantines);
            suma = (Double.Parse(tbTotal.Text)) + ballantines;
            tbTotal.Text = (suma.ToString());
        }

        private void btnJb_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Whisky J&B 5cl = " + jb);
            suma = (Double.Parse(tbTotal.Text)) + jb;
            tbTotal.Text = (suma.ToString());
        }

        private void btnBrugal_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Ron Brugal 5cl = " + brugal);
            suma = (Double.Parse(tbTotal.Text)) + brugal;
            tbTotal.Text = (suma.ToString());
        }

        private void btnCacique_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Ron Cacique 5cl = " + cacique);
            suma = (Double.Parse(tbTotal.Text)) + cacique;
            tbTotal.Text = (suma.ToString());
        }

        private void btnVodka_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Vodka Smirnoff 5cl = " + vodka);
            suma = (Double.Parse(tbTotal.Text)) + vodka;
            tbTotal.Text = (suma.ToString());
        }

        private void btnBeefeater_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Gin Beefeater 5cl = " + beefeater);
            suma = (Double.Parse(tbTotal.Text)) + beefeater;
            tbTotal.Text = (suma.ToString());
        }

        private void btnTanqueray_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Gin Tanqueray 5cl = " + tanqueray);
            suma = (Double.Parse(tbTotal.Text)) + tanqueray;
            tbTotal.Text = (suma.ToString());
        }

        private void btnJagger_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Jägermeister 5cl = " + jagger);
            suma = (Double.Parse(tbTotal.Text)) + jagger;
            tbTotal.Text = (suma.ToString());
        }

        private void btnLicor43_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Licor43 5cl = " + licor43);
            suma = (Double.Parse(tbTotal.Text)) + licor43;
            tbTotal.Text = (suma.ToString());
        }

        private void btnRuavieja_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Licor Hiervas Ruavieja 5cl = " + ruavieja);
            suma = (Double.Parse(tbTotal.Text)) + ruavieja;
            tbTotal.Text = (suma.ToString());
        }

        private void btnCana_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Cerveza Barril 25cl = " + cervezaCana);
            suma = (Double.Parse(tbTotal.Text)) + cervezaCana;
            tbTotal.Text = (suma.ToString());
        }

        private void btnJarra_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Cerveza Barril 50cl = " + cervezaJarra);
            suma = (Double.Parse(tbTotal.Text)) + cervezaJarra;
            tbTotal.Text = (suma.ToString());
        }

        private void btnNegra_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Cerveza Guiness 50cl = " + cervezaNegra);
            suma = (Double.Parse(tbTotal.Text)) + cervezaNegra;
            tbTotal.Text = (suma.ToString());
        }

        private void btnTercio_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Cerveza Nacional 33cl = " + cervezaTercioNacional);
            suma = (Double.Parse(tbTotal.Text)) + cervezaTercioNacional;
            tbTotal.Text = (suma.ToString());
        }

        private void btnExportacion_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Cerveza Exportación 33cl = " + cervezaTercioExportacion);
            suma = (Double.Parse(tbTotal.Text)) + cervezaTercioExportacion;
            tbTotal.Text = (suma.ToString());
        }

        private void btnLays_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Patatas Lays Original = " + patatasLays);
            suma = (Double.Parse(tbTotal.Text)) + patatasLays;
            tbTotal.Text = (suma.ToString());
        }

        private void btnCheetos_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Patatas Cheetos = " + patatasCheetos);
            suma = (Double.Parse(tbTotal.Text)) + patatasCheetos;
            tbTotal.Text = (suma.ToString());
        }

        private void btnKiki_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Cortezas Kiki = " + patatasKiki);
            suma = (Double.Parse(tbTotal.Text)) + patatasKiki;
            tbTotal.Text = (suma.ToString());
        }

        private void btnFritos_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Patatas Fritos de Maiz = " + patatasFritos);
            suma = (Double.Parse(tbTotal.Text)) + patatasFritos;
            tbTotal.Text = (suma.ToString());
        }

        private void btnTradicionales_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Patatas tradicionales = " + patatasTradicionales);
            suma = (Double.Parse(tbTotal.Text)) + patatasTradicionales;
            tbTotal.Text = (suma.ToString());
        }

        private void btnCacahuetes_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Cacahuetes = " + cacahuetes);
            suma = (Double.Parse(tbTotal.Text)) + cacahuetes;
            tbTotal.Text = (suma.ToString());
        }

        private void btnPipas_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Pipas = " + pipas);
            suma = (Double.Parse(tbTotal.Text)) + pipas;
            tbTotal.Text = (suma.ToString());
        }

        private void btnPistachos_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Pistachos = " + pistachos);
            suma = (Double.Parse(tbTotal.Text)) + pistachos;
            tbTotal.Text = (suma.ToString());
        }

        private void btnAceitunas_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Aceitunas = " + aceitunas);
            suma = (Double.Parse(tbTotal.Text)) + aceitunas;
            tbTotal.Text = (suma.ToString());
        }

        private void btnGominolas_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Gominolas = " + gominolas);
            suma = (Double.Parse(tbTotal.Text)) + gominolas;
            tbTotal.Text = (suma.ToString());
        }

        private void btnTabaco_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Marlboro = " + marlboro);
            suma = (Double.Parse(tbTotal.Text)) + marlboro;
            tbTotal.Text = (suma.ToString());
        }

        private void btnPuros_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Puro Cohiba = " + puro);
            suma = (Double.Parse(tbTotal.Text)) + puro;
            tbTotal.Text = (suma.ToString());
        }

        private void btnPuritos_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Add("     € " + "Puritos Reig = " + puritos);
            suma = (Double.Parse(tbTotal.Text)) + puritos;
            tbTotal.Text = (suma.ToString());
        }



        ///////////////////////////////////////////////////////////////////////////////////////////////

        //AHORA LOS BOTONES DE COMANDOS
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listBoxPedido.Items.Clear();
            suma = 0.0;
            tbTotal.Text = (suma.ToString());
            tbDineroEntrega.Text = "";
            tbDineroVuelta.Text = "0.0";
        }

        private void tbDineroEntrega_TextChanged(object sender, EventArgs e)
        {
            
            if(tbDineroEntrega.Text != ""){
                vueltaCalculada = (Double.Parse(tbDineroEntrega.Text)) - (Double.Parse(tbTotal.Text));
                tbDineroVuelta.Text = vueltaCalculada.ToString();
            }
        }



        //BOTONES TECLADO NUMERICO
        private void btn1_Click(object sender, EventArgs e)
        {
            if (tbTotal.Text == "0.0")
            {
                tbTotal.BackColor = Color.Red;
            }
            else {
                tbDineroEntrega.Text = tbDineroEntrega.Text + 1;
            }

            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (tbTotal.Text == "0.0")
            {
                tbTotal.BackColor = Color.Red;
            }
            else
            {
                tbDineroEntrega.Text = tbDineroEntrega.Text + 2;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (tbTotal.Text == "0.0")
            {
                tbTotal.BackColor = Color.Red;
            }
            else
            {
                tbDineroEntrega.Text = tbDineroEntrega.Text + 3;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (tbTotal.Text == "0.0")
            {
                tbTotal.BackColor = Color.Red;
            }
            else
            {
                tbDineroEntrega.Text = tbDineroEntrega.Text + 4;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (tbTotal.Text == "0.0")
            {
                tbTotal.BackColor = Color.Red;
            }
            else
            {
                tbDineroEntrega.Text = tbDineroEntrega.Text + 5;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (tbTotal.Text == "0.0")
            {
                tbTotal.BackColor = Color.Red;
            }
            else
            {
                tbDineroEntrega.Text = tbDineroEntrega.Text + 6;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (tbTotal.Text == "0.0")
            {
                tbTotal.BackColor = Color.Red;
            }
            else
            {
                tbDineroEntrega.Text = tbDineroEntrega.Text + 7;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (tbTotal.Text == "0.0")
            {
                tbTotal.BackColor = Color.Red;
            }
            else
            {
                tbDineroEntrega.Text = tbDineroEntrega.Text + 8;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (tbTotal.Text == "0.0")
            {
                tbTotal.BackColor = Color.Red;
            }
            else
            {
                tbDineroEntrega.Text = tbDineroEntrega.Text + 9;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (tbTotal.Text == "0.0")
            {
                tbTotal.BackColor = Color.Red;
            }
            else
            {
                tbDineroEntrega.Text = tbDineroEntrega.Text + 0;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tbDineroEntrega.Text = "";
            tbDineroVuelta.Text = "0.0";
        }




       
        ///////////////////////////////////////////////////////////////////////

        private void btnPagar_Click(object sender, EventArgs e)
        {

            
            if (tbDineroEntrega.Text == "" || tbTotal.Text.Equals("0") || tbTotal.Text.Equals("0.0"))
            {
                
                tbDineroEntrega.BackColor = Color.Red;
               
            }
            else
            {
                //todo está ok, cerramos venta e imprimimos el ticket
                //ArrayList listaImprimir = new ArrayList();
                listaImprimir.Clear();


                //meto en estas variables para la posibilidad de impresion del ultimo ticket
                totalUltimaCuenta = Double.Parse(tbTotal.Text);
                arrayItems = listBoxPedido.Items.Count;


                for (int i = 0; i < listBoxPedido.Items.Count; i++)
                {
                    listaImprimir.Add(listBoxPedido.Items[i].ToString());
                    

                }
                MessageBox.Show("   'Impresión del ticket'\n\n      Leontini Pub\n   Pasaje de la Purisima nº44\n    Guadix.     74620872-V\n\n    FACTURA SIMPLIFICADA\n\n" + imprimirLista() + "\n\tTOTAL = " + tbTotal.Text + " €\n\n" + "     Gracias por su visita");



                
                listBoxPedido.Items.Clear();
                suma = 0.0;
                tbTotal.Text = (suma.ToString());
                tbDineroEntrega.Text = "";
                tbDineroVuelta.Text = "0.0";

                //poner el color de fondo de nuevo a blanco
                tbDineroEntrega.BackColor = Color.White;
                tbTotal.BackColor = Color.LightGray;


            }
        }

      

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Time to go home! See you tomorrow!");
            Application.Exit();
        }

        private void btnAbrirCaja_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aqui se abriría la caja registradora");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {


            MessageBox.Show("   'Impresión del último ticket'\n\n    Leontini Pub\n  Pasaje de la Purisima nº44\n    Guadix.     74620872-V\n\n    FACTURA SIMPLIFICADA\n\n" + imprimirUltimaLista() + "\n\tTOTAL = " + totalUltimaCuenta + " €\n\n" + "Gracias por su visita");
        }


        private String imprimirLista()
        {
            String lista = "";
            for(int i=0;i<listBoxPedido.Items.Count; i++){
                lista = lista + listBoxPedido.Items[i] + "\n";

            }
            return lista;
        }

        private String imprimirUltimaLista()
        {
            String lista = "";
            for (int i = 0; i < arrayItems ; i++)
            {
                lista = lista + listaImprimir[i] + "\n";

            }
            return lista;
        }


        
    }
}
