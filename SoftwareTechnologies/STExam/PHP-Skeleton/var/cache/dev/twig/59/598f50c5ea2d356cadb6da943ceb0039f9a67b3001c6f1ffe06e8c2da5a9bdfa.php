<?php

/* project/delete.html.twig */
class __TwigTemplate_e96ae7270a11341b1876afd5543a20b46b73c0030e5df66a9382e05bce8babd9 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "project/delete.html.twig", 1);
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
        $__internal_e9326644eeeba95332cc64e0f32e5e4d939cd6aacb5167d87d9623f35fb4c85d = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_e9326644eeeba95332cc64e0f32e5e4d939cd6aacb5167d87d9623f35fb4c85d->enter($__internal_e9326644eeeba95332cc64e0f32e5e4d939cd6aacb5167d87d9623f35fb4c85d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "project/delete.html.twig"));

        $__internal_7b965cab0fb702e554e933e8d3121b7dfcf135f41705c479aacdca71a4a30850 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_7b965cab0fb702e554e933e8d3121b7dfcf135f41705c479aacdca71a4a30850->enter($__internal_7b965cab0fb702e554e933e8d3121b7dfcf135f41705c479aacdca71a4a30850_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "project/delete.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_e9326644eeeba95332cc64e0f32e5e4d939cd6aacb5167d87d9623f35fb4c85d->leave($__internal_e9326644eeeba95332cc64e0f32e5e4d939cd6aacb5167d87d9623f35fb4c85d_prof);

        
        $__internal_7b965cab0fb702e554e933e8d3121b7dfcf135f41705c479aacdca71a4a30850->leave($__internal_7b965cab0fb702e554e933e8d3121b7dfcf135f41705c479aacdca71a4a30850_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_1b8812979c9e462d97731eecb9e35cfcaac3dd6648eb2130630d63b1b3beec8b = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_1b8812979c9e462d97731eecb9e35cfcaac3dd6648eb2130630d63b1b3beec8b->enter($__internal_1b8812979c9e462d97731eecb9e35cfcaac3dd6648eb2130630d63b1b3beec8b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_07d2ae4aea1157898e38618229c1410b442e8ba5005788a1b7cf95b14e15fdab = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_07d2ae4aea1157898e38618229c1410b442e8ba5005788a1b7cf95b14e15fdab->enter($__internal_07d2ae4aea1157898e38618229c1410b442e8ba5005788a1b7cf95b14e15fdab_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

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
        echo "\" disabled=\"disabled\"/>
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\"
                      disabled=\"disabled\">";
        // line 16
        echo twig_escape_filter($this->env, $this->getAttribute(($context["project"] ?? $this->getContext($context, "project")), "description", array()), "html", null, true);
        echo "</textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" value=\"";
        // line 20
        echo twig_escape_filter($this->env, $this->getAttribute(($context["project"] ?? $this->getContext($context, "project")), "budget", array()), "html", null, true);
        echo "\"
                   disabled=\"disabled\"/>
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Delete Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        ";
        // line 28
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "
    </form>
</div>
";
        
        $__internal_07d2ae4aea1157898e38618229c1410b442e8ba5005788a1b7cf95b14e15fdab->leave($__internal_07d2ae4aea1157898e38618229c1410b442e8ba5005788a1b7cf95b14e15fdab_prof);

        
        $__internal_1b8812979c9e462d97731eecb9e35cfcaac3dd6648eb2130630d63b1b3beec8b->leave($__internal_1b8812979c9e462d97731eecb9e35cfcaac3dd6648eb2130630d63b1b3beec8b_prof);

    }

    public function getTemplateName()
    {
        return "project/delete.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  84 => 28,  73 => 20,  66 => 16,  58 => 11,  49 => 4,  40 => 3,  11 => 1,);
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
            <input class=\"create-title-content\" name=\"project[title]\" value=\"{{ project.title }}\" disabled=\"disabled\"/>
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\"
                      disabled=\"disabled\">{{ project.description }}</textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" value=\"{{ project.budget }}\"
                   disabled=\"disabled\"/>
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Delete Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        {{ form_row(form._token) }}
    </form>
</div>
{% endblock %}", "project/delete.html.twig", "C:\\Users\\Ship\\Desktop\\STExam\\PHP-Skeleton\\app\\Resources\\views\\project\\delete.html.twig");
    }
}
