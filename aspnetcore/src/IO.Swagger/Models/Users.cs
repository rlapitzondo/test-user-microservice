/*
 * User MicroService
 *
 * Microservicio de acceso a legado de Usuarios
 *
 * OpenAPI spec version: 0.0.1
 * Contact: raul.lapitzondo@it2insurance.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Users : IEquatable<Users>
    { 
        /// <summary>
        /// Gets or Sets IdUser
        /// </summary>
        [DataMember(Name="id_user")]
        public string IdUser { get; set; }

        /// <summary>
        /// Gets or Sets Nombre
        /// </summary>
        [DataMember(Name="nombre")]
        public string Nombre { get; set; }

        /// <summary>
        /// Gets or Sets Apellido
        /// </summary>
        [DataMember(Name="apellido")]
        public string Apellido { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email")]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Users {\n");
            sb.Append("  IdUser: ").Append(IdUser).Append("\n");
            sb.Append("  Nombre: ").Append(Nombre).Append("\n");
            sb.Append("  Apellido: ").Append(Apellido).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Users)obj);
        }

        /// <summary>
        /// Returns true if Users instances are equal
        /// </summary>
        /// <param name="other">Instance of Users to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Users other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IdUser == other.IdUser ||
                    IdUser != null &&
                    IdUser.Equals(other.IdUser)
                ) && 
                (
                    Nombre == other.Nombre ||
                    Nombre != null &&
                    Nombre.Equals(other.Nombre)
                ) && 
                (
                    Apellido == other.Apellido ||
                    Apellido != null &&
                    Apellido.Equals(other.Apellido)
                ) && 
                (
                    Email == other.Email ||
                    Email != null &&
                    Email.Equals(other.Email)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (IdUser != null)
                    hashCode = hashCode * 59 + IdUser.GetHashCode();
                    if (Nombre != null)
                    hashCode = hashCode * 59 + Nombre.GetHashCode();
                    if (Apellido != null)
                    hashCode = hashCode * 59 + Apellido.GetHashCode();
                    if (Email != null)
                    hashCode = hashCode * 59 + Email.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Users left, Users right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Users left, Users right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
