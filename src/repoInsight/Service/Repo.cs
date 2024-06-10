using repoInsight.Models;
using repoInsight.Data;

namespace repoInsight.Services;

public static class RepoService
{
    public static List<Repo> ListRepos(RepoInsightContext _context, string email)
    {
        var repos = from r in _context.Repo join u in _context.Usuario on r.IdUsuario equals u.Id where u.Email == email select r;
        return repos.ToList();
    }
}

public static class RepoHelper
{
    public static Tuple<List<Repo>, Repo, List<Repo>> ToTuple(this List<Repo> repos)
    {
        var ultimos = repos.OrderByDescending(r => r.DataVisita).Take(3).Select(r => r).ToList();
        var tuple = new Tuple<List<Repo>, Repo, List<Repo>>(repos.ToList(), new Repo(), ultimos);
        return tuple;
    }
}