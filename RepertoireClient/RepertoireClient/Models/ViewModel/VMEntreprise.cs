﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepertoireClient.ViewModel
{
    public class Entreprise
    {
        #region Variables

        #region Informations générales

        /// <summary>
        /// Identifiant unique de l'entreprise
        /// </summary>
        public int ID;

        /// <summary>
        /// Nom de l'entreprise
        /// </summary>
        public string Nom;

        /// <summary>
        /// Site internet de l'entreprise
        /// </summary>
        public string Site;

        /// <summary>
        /// Code de donneur d'ordres
        /// </summary>
        public string Code_Ordre;

        /// <summary>
        /// Numéro de téléphone de l'entreprise
        /// </summary>
        public string Telephone;

        /// <summary>
        /// Fax de l'entreprise
        /// </summary>
        public string Fax;

        #endregion

        #region Horraires

        /// <summary>
        /// Heure d'ouverture (Matin) de l'entreprise
        /// </summary>
        public DateTime OuvertureAM;

        /// <summary>
        /// Heure de fermeture (Matin) de l'entreprise
        /// </summary>
        public DateTime FermetureAM;

        /// <summary>
        /// Heure d'ouverture (Après-midi) de l'entreprise
        /// </summary>
        public DateTime OuverturePM;

        /// <summary>
        /// Heure de fermeture (Après-midi) de l'entreprise
        /// </summary>
        public DateTime FermeturePM;

        /// <summary>
        /// Spécificités des fermetures exceptionnelles
        /// </summary>
        public string Fermeture_exceptionnelleSpecification;

        /// <summary>
        /// Jour et heure de fermeture exceptionnelle le matin
        /// </summary>
        public DateTime Fermeture_exceptionnelleAM;

        /// <summary>
        /// Jour et heure de fermeture exceptionnelle l'après-midi
        /// </summary>
        public DateTime Fermeture_exceptionnellePM;

        #endregion

        #region Coordonnées

        /// <summary>
        /// Rue de l'entreprise
        /// </summary>
        public string Rue;

        /// <summary>
        /// Code postal de l'entreprise
        /// </summary>
        public string Code_Postal;

        /// <summary>
        /// Ville de l'entreprise
        /// </summary>
        public string Ville;

        /// <summary>
        /// Liste des contacts dans l'entreprise
        /// </summary>
        public List<Employee> Contacts;

        #endregion

        #region Materiel

        /// <summary>
        /// L'entreprise est équipée d'un porteur
        /// </summary>
        public bool Porteur;

        /// <summary>
        /// L'entreprise est équipée de semis remorques
        /// </summary>
        public bool Semis_Remorque;

        /// <summary>
        /// L'entreprise est équipée de Vul
        /// </summary>
        public bool Vul;

        /// <summary>
        /// L'entreprise est équipée de haillons
        /// </summary>
        public bool Haillon;

        /// <summary>
        /// L'entreprise est équipée de tire palettes
        /// </summary>
        public bool Tire_Palette;

        /// <summary>
        /// L'entreprise est équipée de Tautliner
        /// </summary>
        public bool Remorque_Tautliner;

        /// <summary>
        /// L'entrepise est équipée de fourgons
        /// </summary>
        public bool Remorque_Fourgon;

        /// <summary>
        /// l'entreprise est équipée de remorques frigorifiques
        /// </summary>
        public bool Remorque_Frigorifique;

        #endregion


        /// <summary>
        /// Commentaire sur l'entreprise
        /// </summary>
        public string Commentaire;

        #endregion

        public Entreprise()
        {
            
        }

        public Models.Entreprise toModels()
        {
            return new Models.Entreprise()
            {
                ID = this.ID,
                Nom = this.Nom,
                Site = this.Site,
                Code_Ordre = this.Code_Ordre,
                Telephone = this.Telephone,
                Fax = this.Fax,
                OuvertureAM = this.OuvertureAM,
                FermetureAM = this.FermetureAM,
                OuverturePM = this.OuverturePM,
                FermeturePM = this.FermeturePM,
                Fermeture_exceptionnelleSpecification = this.Fermeture_exceptionnelleSpecification,
                Fermeture_exceptionnelleAM = this.Fermeture_exceptionnelleAM,
                Fermeture_exceptionnellePM = this.Fermeture_exceptionnellePM,
                Rue = this.Rue,
                Code_Postal = this.Code_Postal,
                Ville = this.Ville,
                Porteur = this.Porteur,
                Semis_Remorque = this.Semis_Remorque,
                Vul = this.Vul,
                Haillon = this.Haillon,
                Tire_Palette = this.Tire_Palette,
                Remorque_Tautliner = this.Remorque_Tautliner,
                Remorque_Fourgon = this.Remorque_Fourgon,
                Remorque_Frigorifique = this.Remorque_Frigorifique,
                Commentaire = this.Commentaire
            };
        }
    }
}