<?php

/* project/edit.html.twig */
class __TwigTemplate_f87bd5160ece83d12b7f4659cc2b9f9000fb392b743a79100d9e32743f557ed4 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "project/edit.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_6372c1803700097ff2a532de1083f885362db55025abc1f39cfbcd347eeb8564 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_6372c1803700097ff2a532de1083f885362db55025abc1f39cfbcd347eeb8564->enter($__internal_6372c1803700097ff2a532de1083f885362db55025abc1f39cfbcd347eeb8564_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "project/edit.html.twig"));

        $__internal_f3330835c19a842a3e9773c9c81daae79b351b11356a4b7efa20a80631893102 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f3330835c19a842a3e9773c9c81daae79b351b11356a4b7efa20a80631893102->enter($__internal_f3330835c19a842a3e9773c9c81daae79b351b11356a4b7efa20a80631893102_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "project/edit.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_6372c1803700097ff2a532de1083f885362db55025abc1f39cfbcd347eeb8564->leave($__internal_6372c1803700097ff2a532de1083f885362db55025abc1f39cfbcd347eeb8564_prof);

        
        $__internal_f3330835c19a842a3e9773c9c81daae79b351b11356a4b7efa20a80631893102->leave($__internal_f3330835c19a842a3e9773c9c81daae79b351b11356a4b7efa20a80631893102_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_2b16d957bf932f9bf7fc4425481a349f4341e784172c8c45029de979a2d6ba14 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_2b16d957bf932f9bf7fc4425481a349f4341e784172c8c45029de979a2d6ba14->enter($__internal_2b16d957bf932f9bf7fc4425481a349f4341e784172c8c45029de979a2d6ba14_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_ae7a822e29937be398687a47b21ddeb78787540423dad2b8dfab5ffcff1fa816 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ae7a822e29937be398687a47b21ddeb78787540423dad2b8dfab5ffcff1fa816->enter($__internal_ae7a822e29937be398687a47b21ddeb78787540423dad2b8dfab5ffcff1fa816_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<div class=\"wrapper\">
    <form class=\"project-create\" method=\"post\">
        <div class=\"create-header\">
            Delete Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" value=\"";
        // line 11
        echo twig_escape_filter($this->env, $this->getAttribute(($context["project"] ?? $this->getContext($context, "project")), "title", array()), "html", null, true);
        echo "\" />
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\">";
        // line 15
        echo twig_escape_filter($this->env, $this->getAttribute(($context["project"] ?? $this->getContext($context, "project")), "description", array()), "html", null, true);
        echo "</textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" value=\"";
        // line 19
        echo twig_escape_filter($this->env, $this->getAttribute(($context["project"] ?? $this->getContext($context, "project")), "budget", array()), "html", null, true);
        echo "\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Edit Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        ";
        // line 26
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "
    </form>
</div>
";
        
        $__internal_ae7a822e29937be398687a47b21ddeb78787540423dad2b8dfab5ffcff1fa816->leave($__internal_ae7a822e29937be398687a47b21ddeb78787540423dad2b8dfab5ffcff1fa816_prof);

        
        $__internal_2b16d957bf932f9bf7fc4425481a349f4341e784172c8c45029de979a2d6ba14->leave($__internal_2b16d957bf932f9bf7fc4425481a349f4341e784172c8c45029de979a2d6ba14_prof);

    }

    public function getTemplateName()
    {
        return "project/edit.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  82 => 26,  72 => 19,  65 => 15,  58 => 11,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
<div class=\"wrapper\">
    <form class=\"project-create\" method=\"post\">
        <div class=\"create-header\">
            Delete Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" value=\"{{ project.title }}\" />
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\">{{ project.description }}</textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" value=\"{{ project.budget }}\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Edit Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        {{ form_row(form._token) }}
    </form>
</div>
{% endblock %}

", "project/edit.html.twig", "C:\\Users\\Ship\\Desktop\\STExam\\PHP-Skeleton\\app\\Resources\\views\\project\\edit.html.twig");
    }
}
