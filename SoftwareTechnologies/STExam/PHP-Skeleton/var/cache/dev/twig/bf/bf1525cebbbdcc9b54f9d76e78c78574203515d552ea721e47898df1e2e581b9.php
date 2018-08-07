<?php

/* project/create.html.twig */
class __TwigTemplate_2a1b5d707aa72104692b6ffa1a05c4fb1e74d1bf350d67ef9d0e176233c33cfd extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "project/create.html.twig", 1);
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
        $__internal_1cf5b00b4f154dab31a2eff1f2a5e4b9afb51aa795ddcd860f78e879e242df0d = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_1cf5b00b4f154dab31a2eff1f2a5e4b9afb51aa795ddcd860f78e879e242df0d->enter($__internal_1cf5b00b4f154dab31a2eff1f2a5e4b9afb51aa795ddcd860f78e879e242df0d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "project/create.html.twig"));

        $__internal_dd3b7eac601b2acd13d26a96fee8012241c9aa57683bb254f510dcdb5f1dddac = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_dd3b7eac601b2acd13d26a96fee8012241c9aa57683bb254f510dcdb5f1dddac->enter($__internal_dd3b7eac601b2acd13d26a96fee8012241c9aa57683bb254f510dcdb5f1dddac_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "project/create.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_1cf5b00b4f154dab31a2eff1f2a5e4b9afb51aa795ddcd860f78e879e242df0d->leave($__internal_1cf5b00b4f154dab31a2eff1f2a5e4b9afb51aa795ddcd860f78e879e242df0d_prof);

        
        $__internal_dd3b7eac601b2acd13d26a96fee8012241c9aa57683bb254f510dcdb5f1dddac->leave($__internal_dd3b7eac601b2acd13d26a96fee8012241c9aa57683bb254f510dcdb5f1dddac_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_af5a0586acfb4e0ac5dacc4eb1a980b89c23f8cb7fb0305bf61b685cd8892f2f = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_af5a0586acfb4e0ac5dacc4eb1a980b89c23f8cb7fb0305bf61b685cd8892f2f->enter($__internal_af5a0586acfb4e0ac5dacc4eb1a980b89c23f8cb7fb0305bf61b685cd8892f2f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_36015c592c2abbc5f00db15d24b636ae73d7f98b7929852c63755412b69907fa = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_36015c592c2abbc5f00db15d24b636ae73d7f98b7929852c63755412b69907fa->enter($__internal_36015c592c2abbc5f00db15d24b636ae73d7f98b7929852c63755412b69907fa_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<div class=\"wrapper\">
    <form class=\"project-create\" method=\"post\">
        <div class=\"create-header\">
            Create Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" />
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\"></textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Create Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        ";
        // line 26
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "
    </form>
</div>
";
        
        $__internal_36015c592c2abbc5f00db15d24b636ae73d7f98b7929852c63755412b69907fa->leave($__internal_36015c592c2abbc5f00db15d24b636ae73d7f98b7929852c63755412b69907fa_prof);

        
        $__internal_af5a0586acfb4e0ac5dacc4eb1a980b89c23f8cb7fb0305bf61b685cd8892f2f->leave($__internal_af5a0586acfb4e0ac5dacc4eb1a980b89c23f8cb7fb0305bf61b685cd8892f2f_prof);

    }

    public function getTemplateName()
    {
        return "project/create.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  73 => 26,  49 => 4,  40 => 3,  11 => 1,);
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
            Create Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" />
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\"></textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Create Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        {{ form_row(form._token) }}
    </form>
</div>
{% endblock %}", "project/create.html.twig", "C:\\Users\\Ship\\Desktop\\STExam\\PHP-Skeleton\\app\\Resources\\views\\project\\create.html.twig");
    }
}
