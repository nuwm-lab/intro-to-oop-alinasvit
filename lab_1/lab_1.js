class ArithmeticProgression {
  constructor(firstTerm, difference, numberOfTerms) {
    this.firstTerm = firstTerm;
    this.difference = difference;
    this.numberOfTerms = numberOfTerms;
  }

  sum() {
    return (
      (this.numberOfTerms / 2) *
      (2 * this.firstTerm + (this.numberOfTerms - 1) * this.difference)
    );
  }
}

const progression = new ArithmeticProgression(1, 3, 5);
const sum = progression.sum();

console.log(`Progression sum: ${sum}`);
