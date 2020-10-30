using Krafted.DesignPatterns.Ddd;
using Krafted.Guards;

namespace Krafted.ValueObjects.Pt
{
    /// <summary>
    /// Represents an NIF value object.
    /// </summary>
    /// <remarks>
    /// NIF means "Número de Identificação Fiscal", a.k.a "Número de Contribuinte",
    /// identifies a taxpayer entity in Portugal, whether it is a company or an individual.
    /// <see href="https://pt.wikipedia.org/wiki/N%C3%BAmero_de_identifica%C3%A7%C3%A3o_fiscal">See more</see>.
    /// </remarks>
    public sealed class Nif : ValueObject<string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Nif"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public Nif(string value)
        {
            Guard.Against.InvalidNif(value);
            Value = value;
        }

        // Required for the ORM.
        private Nif()
        {
        }

        /// <summary>
        /// Performs an explicit conversion from <see cref="string"/> to <see cref="Nif"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Nif(string value) => new Nif(value);

        /// <summary>
        /// Initializes a new instance of the <see cref="Nif"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>A new instance of the <see cref="Nif"/> class.</returns>
        public static Nif NewNif(string value) => new Nif(value);
    }
}
