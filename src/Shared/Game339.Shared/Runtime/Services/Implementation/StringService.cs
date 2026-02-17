using System;
using System.Linq;
using Game339.Shared.Diagnostics;

namespace Game339.Shared.Services.Implementation
{
    public class StringService : IStringService
    {
        private readonly IGameLog _log;

        public StringService(IGameLog log)
        {
            _log = log;
        }

        public string Reverse(string input)
        {

            if (input == null) throw new ArgumentNullException(nameof(input));


            var output = new string(input.Reverse().ToArray());
            _log.Info($"{nameof(StringService)}.{nameof(Reverse)} - {nameof(input)}: {input} - {nameof(output)}: {output}");
            return output;
        }

        public string ReverseWords(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            var words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);

            var output = string.Join(" ", words);

            _log.Info($"{nameof(StringService)}.{nameof(ReverseWords)} - {nameof(input)}: {input} - {nameof(output)}: {output}");
            return output;
        }


    }
}