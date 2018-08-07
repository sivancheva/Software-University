<?php

/* base.html.twig */
class __TwigTemplate_93e2499d03c6402ea1e3906495568257ed0120721f7f5badb0e11600e82927c5 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_7ca81b10d66dfd1713e1b91d91e2a59fba10ff5c368e43bf54f17acb9d05129d = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_7ca81b10d66dfd1713e1b91d91e2a59fba10ff5c368e43bf54f17acb9d05129d->enter($__internal_7ca81b10d66dfd1713e1b91d91e2a59fba10ff5c368e43bf54f17acb9d05129d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        $__internal_8b14e5b3e01e72f9f79e43185fbf4457fe2a083d885009a59ff4750136a9219e = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_8b14e5b3e01e72f9f79e43185fbf4457fe2a083d885009a59ff4750136a9219e->enter($__internal_8b14e5b3e01e72f9f79e43185fbf4457fe2a083d885009a59ff4750136a9219e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 6
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <title>";
        // line 10
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 11
        $this->displayBlock('stylesheets', $context, $blocks);
        // line 16
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 19
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">
";
        // line 20
        $this->displayBlock('body', $context, $blocks);
        // line 23
        echo "</body>
</html>
";
        
        $__internal_7ca81b10d66dfd1713e1b91d91e2a59fba10ff5c368e43bf54f17acb9d05129d->leave($__internal_7ca81b10d66dfd1713e1b91d91e2a59fba10ff5c368e43bf54f17acb9d05129d_prof);

        
        $__internal_8b14e5b3e01e72f9f79e43185fbf4457fe2a083d885009a59ff4750136a9219e->leave($__internal_8b14e5b3e01e72f9f79e43185fbf4457fe2a083d885009a59ff4750136a9219e_prof);

    }

    // line 10
    public function block_title($context, array $blocks = array())
    {
        $__internal_d8eef6838a8b8c8ff614f98b3c5d8c7eb96aa2b47acb2497b38c60751602fb26 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_d8eef6838a8b8c8ff614f98b3c5d8c7eb96aa2b47acb2497b38c60751602fb26->enter($__internal_d8eef6838a8b8c8ff614f98b3c5d8c7eb96aa2b47acb2497b38c60751602fb26_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_0262fa83775170efafad1edfc1eed9dca6dcfc54aaaa0458eeea63bc16e76d18 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_0262fa83775170efafad1edfc1eed9dca6dcfc54aaaa0458eeea63bc16e76d18->enter($__internal_0262fa83775170efafad1edfc1eed9dca6dcfc54aaaa0458eeea63bc16e76d18_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "Project Rider";
        
        $__internal_0262fa83775170efafad1edfc1eed9dca6dcfc54aaaa0458eeea63bc16e76d18->leave($__internal_0262fa83775170efafad1edfc1eed9dca6dcfc54aaaa0458eeea63bc16e76d18_prof);

        
        $__internal_d8eef6838a8b8c8ff614f98b3c5d8c7eb96aa2b47acb2497b38c60751602fb26->leave($__internal_d8eef6838a8b8c8ff614f98b3c5d8c7eb96aa2b47acb2497b38c60751602fb26_prof);

    }

    // line 11
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_4114e9a104d885720086f9f34a3d3d700cc5fb2dd6ca331a6000a1b35b1354e8 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_4114e9a104d885720086f9f34a3d3d700cc5fb2dd6ca331a6000a1b35b1354e8->enter($__internal_4114e9a104d885720086f9f34a3d3d700cc5fb2dd6ca331a6000a1b35b1354e8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        $__internal_272f9bbc1ef82b52667c34cd2d46c41303faf4a54204af2f1c520ca948b0a52e = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_272f9bbc1ef82b52667c34cd2d46c41303faf4a54204af2f1c520ca948b0a52e->enter($__internal_272f9bbc1ef82b52667c34cd2d46c41303faf4a54204af2f1c520ca948b0a52e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 12
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/reset.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 13
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 14
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/create-style.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_272f9bbc1ef82b52667c34cd2d46c41303faf4a54204af2f1c520ca948b0a52e->leave($__internal_272f9bbc1ef82b52667c34cd2d46c41303faf4a54204af2f1c520ca948b0a52e_prof);

        
        $__internal_4114e9a104d885720086f9f34a3d3d700cc5fb2dd6ca331a6000a1b35b1354e8->leave($__internal_4114e9a104d885720086f9f34a3d3d700cc5fb2dd6ca331a6000a1b35b1354e8_prof);

    }

    // line 19
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_4a3a15eabb78602505387511dad7fd05bf8dc04a66b651ae121a77d6e0d173bd = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_4a3a15eabb78602505387511dad7fd05bf8dc04a66b651ae121a77d6e0d173bd->enter($__internal_4a3a15eabb78602505387511dad7fd05bf8dc04a66b651ae121a77d6e0d173bd_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        $__internal_45d134e4993ca680cf9034b3e341087509c56d9372c6078b55eab41ea613ceeb = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_45d134e4993ca680cf9034b3e341087509c56d9372c6078b55eab41ea613ceeb->enter($__internal_45d134e4993ca680cf9034b3e341087509c56d9372c6078b55eab41ea613ceeb_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_45d134e4993ca680cf9034b3e341087509c56d9372c6078b55eab41ea613ceeb->leave($__internal_45d134e4993ca680cf9034b3e341087509c56d9372c6078b55eab41ea613ceeb_prof);

        
        $__internal_4a3a15eabb78602505387511dad7fd05bf8dc04a66b651ae121a77d6e0d173bd->leave($__internal_4a3a15eabb78602505387511dad7fd05bf8dc04a66b651ae121a77d6e0d173bd_prof);

    }

    // line 20
    public function block_body($context, array $blocks = array())
    {
        $__internal_200a8953621c220cdab04e7ccd93662f7c75fce7b30fd6a75adce6f61180f160 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_200a8953621c220cdab04e7ccd93662f7c75fce7b30fd6a75adce6f61180f160->enter($__internal_200a8953621c220cdab04e7ccd93662f7c75fce7b30fd6a75adce6f61180f160_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_4ada4b3ed605fbdb3d99cef51f5e969a7355ffed22d5158eefae720d40dc40d3 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_4ada4b3ed605fbdb3d99cef51f5e969a7355ffed22d5158eefae720d40dc40d3->enter($__internal_4ada4b3ed605fbdb3d99cef51f5e969a7355ffed22d5158eefae720d40dc40d3_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 21
        echo "    ";
        $this->displayBlock('main', $context, $blocks);
        
        $__internal_4ada4b3ed605fbdb3d99cef51f5e969a7355ffed22d5158eefae720d40dc40d3->leave($__internal_4ada4b3ed605fbdb3d99cef51f5e969a7355ffed22d5158eefae720d40dc40d3_prof);

        
        $__internal_200a8953621c220cdab04e7ccd93662f7c75fce7b30fd6a75adce6f61180f160->leave($__internal_200a8953621c220cdab04e7ccd93662f7c75fce7b30fd6a75adce6f61180f160_prof);

    }

    public function block_main($context, array $blocks = array())
    {
        $__internal_480f487ab40497c3646b36391bbf9ce29882bfdc9220e88e77abb6c644d07f71 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_480f487ab40497c3646b36391bbf9ce29882bfdc9220e88e77abb6c644d07f71->enter($__internal_480f487ab40497c3646b36391bbf9ce29882bfdc9220e88e77abb6c644d07f71_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_f2377bd24b1927182dd56eef58ca2c1f551ce14684ab554537e20bf45921797f = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f2377bd24b1927182dd56eef58ca2c1f551ce14684ab554537e20bf45921797f->enter($__internal_f2377bd24b1927182dd56eef58ca2c1f551ce14684ab554537e20bf45921797f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_f2377bd24b1927182dd56eef58ca2c1f551ce14684ab554537e20bf45921797f->leave($__internal_f2377bd24b1927182dd56eef58ca2c1f551ce14684ab554537e20bf45921797f_prof);

        
        $__internal_480f487ab40497c3646b36391bbf9ce29882bfdc9220e88e77abb6c644d07f71->leave($__internal_480f487ab40497c3646b36391bbf9ce29882bfdc9220e88e77abb6c644d07f71_prof);

    }

    public function getTemplateName()
    {
        return "base.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  141 => 21,  132 => 20,  115 => 19,  103 => 14,  99 => 13,  94 => 12,  85 => 11,  67 => 10,  55 => 23,  53 => 20,  49 => 19,  42 => 16,  40 => 11,  36 => 10,  30 => 6,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <title>{% block title %}Project Rider{% endblock %}</title>
    {% block stylesheets %}
        <link rel=\"stylesheet\" href=\"{{ asset('css/reset.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/create-style.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">
{% block body %}
    {% block main %}{% endblock %}
{% endblock %}
</body>
</html>
", "base.html.twig", "C:\\Users\\Ship\\Desktop\\STExam\\PHP-Skeleton\\app\\Resources\\views\\base.html.twig");
    }
}
