using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sokszogek.Models;

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
        }

        private double _terulet;

        public double Terulet
        {
            get { return _terulet; }
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

        private void Szamitas()
        {
            switch (_kijeloltElem)
            {
                case "Négyzet":
                    _oldalB = 0; _oldalC = 0;
                    OnPropertyChanged("OldalB");
                    OnPropertyChanged("OldalC");
                    var negyzet = new Negyzet(OldalA);
                    _kerulet = negyzet.Kerulet();
                    _terulet = negyzet.Terulet();
                    OnPropertyChanged("Kerulet");
                    OnPropertyChanged("Terulet");
                    break;
                case "Téglalap":_oldalC = 0;
                    OnPropertyChanged("OldalC");
                    var teglalap = new Teglalap(OldalA, OldalB);
                    _kerulet = teglalap.Kerulet();
                    _terulet = teglalap.Terulet();
                    OnPropertyChanged("Kerulet");
                    OnPropertyChanged("Terulet");
                    break;
                case "Háromszög":
                    var haromszog = new Haromszog(OldalA, OldalB, OldalC);
                    _kerulet = haromszog.Kerulet();
                    _terulet = haromszog.Terulet();
                    OnPropertyChanged("Kerulet");
                    OnPropertyChanged("Terulet");
                    break;
                default:
                    break;
            }
        }

        public MainViewModel()
        {
            SokszogList = new ObservableCollection<string>();
            SokszogList.Add("Négyzet");
            SokszogList.Add("Téglalap");
            SokszogList.Add("Háromszög");
        }
    }
}
