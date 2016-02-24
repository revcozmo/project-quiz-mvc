﻿namespace QuizProjectMvc.Services.Data
{
    using System.Linq;
    using Models;
    using Models.Evaluation;
    using Models.Search;
    using QuizProjectMvc.Data.Models;

    public interface IQuizzesService
    {
        IQueryable<Quiz> GetRandomQuizzes(int count);

        QuizEvaluationResult EvaluateSolution(QuizSolution quizSolution);

        QuizSolution SaveSolution(SolutionForEvaluationModel quizSolution, Quiz quiz, string userId);

        Quiz GetById(string id);

        Quiz GetById(int id);

        IQueryable<Quiz> SearchQuizzes(QuizSearchModel queryParameters);

        IQueryable<Quiz> GetPage(Pager pager);

        void Add(Quiz quiz);
    }
}
