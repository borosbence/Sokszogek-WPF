using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Sokszogek.Models;
using Sokszogek.UI.Commands;

namespace Sokszogek.UI.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        private double _oldalA;
        public double OldalA
        {
            get { return _oldalA; }
            set {
                SetProperty(ref _oldalA, value);
                Szamitas();
            }
        }

        private double _oldalB;
        public double OldalB
        {
            get { return _oldalB; }
            set { 
                SetProperty(ref _oldalB, value);
                Szamitas();
            }
        }

        private double _oldalC;
        public double OldalC
        {
            get { return _oldalC; }
            set { 
                SetProperty(ref _oldalC, value);
                Szamitas();
            }
        }

        private double _kerulet;
        public double Kerulet
        {
            get { return _kerulet; }
            set { SetProperty(ref _kerulet, value); }
        }

        private double _terulet;

        public double Terulet
        {
            get { return _terulet; }
            set { SetProperty(ref _terulet, value); }
        }

        private ObservableCollection<string> _sokszogList;
        public ObservableCollection<string> SokszogList
        {
            get { return _sokszogList; }
            set { _sokszogList = value; }
        }

        private string _kijeloltElem;

        public string KijeloltElem
        {
            get { return _kijeloltElem; }
            set {
                _kijeloltElem = value;
                Szamitas();
            }
        }

        public MainViewModel()
        {
            SokszogList = new ObservableCollection<string>();
            SokszogList.Add("Négyzet");
            SokszogList.Add("Téglalap");
            SokszogList.Add("Háromszög");
        }

        public void Szamitas()
        {
            switch (_kijeloltElem)
            {
                case "Négyzet":
                    var negyzet = new Negyzet(OldalA);
                    Kerulet = negyzet.Kerulet();
                    Terulet = negyzet.Terulet();
                    break;
                case "Téglalap":
                    var teglalap = new Teglalap(OldalA, OldalB);
                    Kerulet = teglalap.Kerulet();
                    Terulet = teglalap.Terulet();
                    break;
                case "Háromszög":
                    var haromszog = new Haromszog(OldalA, OldalB, OldalC);
                    Kerulet = haromszog.Kerulet();
                    Terulet = haromszog.Terulet();
                    break;
                default:
                    break;
            }
        }
    }
}
