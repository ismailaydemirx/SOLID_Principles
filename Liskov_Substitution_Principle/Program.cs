#region Not Ideal Code

//using Liskov_Substitution_Principle_Not_Ideal_Code;

//Cloud cloud = new AWS(); // Base class reference points to AWS instance
//cloud.Translate();
//cloud.MachineLearning();

//cloud = new Google(); // Base reference reassigned to Google (polymorphic substitution)
//cloud.Translate();
//cloud.MachineLearning();

//cloud = new Azure(); // base reference changed to Azure
//cloud.Translate(); // Throws exception -> LSP violation (Azure cannot fully substitute Cloud)
//cloud.MachineLearning();

#endregion

#region Ideal Code

using Liskov_Substitution_Principle_Ideal_Code;

// Cloud base class reference points to AWS instance
Cloud cloud = new AWS();
cloud.MachineLearning();// Guaranteed behavior: every Cloud can do MachineLearning

// Optional behavior: only clouds that implement ITranslatable can Translate
// Safe cast using 'as' prevents runtime exception (LSP-compliant)
(cloud as ITranslatable)?.Translate();

// Base reference is reassigned to Google (polymorphism)
cloud = new Google();
cloud.MachineLearning();
(cloud as ITranslatable)?.Translate(); // Google also implements ITranslatable, so Translate is executed

// Base reference is reassigned to Azure
cloud = new Azure();
cloud.MachineLearning();

// Azure does NOT implement ITranslatable
// Safe cast returns null, Translate is skipped (no exception, no LSP violation)


#endregion